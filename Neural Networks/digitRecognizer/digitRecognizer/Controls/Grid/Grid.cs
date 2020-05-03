using System;
using System.Drawing;
using static System.Math;

namespace digitRecognizer.Controls.Grid
{
	public class Grid : IDisposable
	{
		// FIELDS
		private readonly Color[,] canvas;
		private int rowsAmount;
		private int colsAmount;
		private float cellWidth;
		private float cellHeight;
		private int width;
		private int height;

		private bool disposedValue;
		private Bitmap bitmap;
		private Graphics graphics;
		private readonly Pen cellBorderPen;
		private readonly SolidBrush cellFillBrush;

		// CONSTRUCTORS
		public Grid(int rows, int cols, int width, int height)
		{
			this.rowsAmount = rows;
			this.colsAmount = cols;
			this.width = width;
			this.height = height;
			this.cellWidth = width / colsAmount;
			this.cellHeight = height / rowsAmount;

			this.canvas = new Color[rowsAmount, colsAmount];
			this.Clear();

			// initialize drawing tools
			this.disposedValue = false;
			this.bitmap = new Bitmap(width, height);
			this.graphics = Graphics.FromImage(bitmap);
			this.cellBorderPen = new Pen(Color.White);
			this.cellFillBrush = new SolidBrush(Color.Black);
		}
		~Grid()
		{
			Dispose(false);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					bitmap.Dispose();
					graphics.Dispose();
					cellBorderPen.Dispose();
					cellFillBrush.Dispose();
				}

				disposedValue = true;
			}
		}
		void IDisposable.Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		// PROPERTIES
		public int Cols
		{
			get
			{
				return colsAmount;
			}
			set
			{
				if (colsAmount != value)
				{
					colsAmount = value;
					OnGridSizeChanged(EventArgs.Empty);
				}
			}
		}
		public int Rows
		{
			get
			{
				return rowsAmount;
			}
			set
			{
				if (rowsAmount != value)
				{
					rowsAmount = value;
					OnGridSizeChanged(EventArgs.Empty);
				}
			}
		}
		public int Width
		{
			get
			{
				return width;
			}
			set
			{
				if (width != value)
				{
					width = value;
					OnGridSizeChanged(EventArgs.Empty);
				}
			}
		}
		public int Height
		{
			get
			{
				return height;
			}
			set
			{
				if (height != value)
				{
					height = value;
					OnGridSizeChanged(EventArgs.Empty);
				}
			}
		}

		// INDEXERS
		public Color this[int i, int j]
		{
			get
			{
				return canvas[i, j];
			}
			set
			{
				canvas[i, j] = value;
			}
		}

		// EVENTS
		public event EventHandler<CellColorChangedEventArgs> CellColorChanged;
		public event EventHandler GridSizeChanged;

		// METHODS
		public void Draw(byte[] colorsCodes)
		{
			int index = 0;
			for (int i = 0; i < rowsAmount; ++i)
			{
				for (int j = 0; j < colsAmount; ++j)
				{
					byte color = colorsCodes[index++];
					canvas[i, j] = Color.FromArgb(color, color, color);
				}
			}
		}

		public Bitmap Show()
		{
			for (int i = 0; i < rowsAmount; ++i)
			{
				for (int j = 0; j < colsAmount; ++j)
				{
					cellFillBrush.Color = canvas[i, j];

					graphics.FillRectangle(cellFillBrush, j * cellWidth, i * cellHeight, cellWidth, cellHeight);
					graphics.DrawRectangle(cellBorderPen, j * cellWidth, i * cellHeight, cellWidth, cellHeight);
				}
			}
			return bitmap;
		}
		public void FillCellFromPixel(int clickX, int clickY, Color newColor)
		{
			int i = (int)Floor(clickY / cellHeight);
			int j = (int)Floor(clickX / cellWidth);

			canvas[i, j] = newColor;
			OnCellColorChanged(new CellColorChangedEventArgs(j * cellWidth, i * cellHeight, cellWidth, cellHeight, newColor));
		}
		public void MakeBrighterCellFromPixel(int clickX, int clickY)
		{
			int i = (int)Floor(clickY / cellHeight);
			int j = (int)Floor(clickX / cellWidth);

			canvas[i, j] = System.Windows.Forms.ControlPaint.Light(canvas[i, j]);

			OnCellColorChanged(new CellColorChangedEventArgs(j * cellWidth, i * cellHeight, cellWidth, cellHeight, canvas[i, j]));

		}
		public double[] ToColorDoubleArray()
		{
			double[] arr = new double[canvas.Length];
			int index = 0;
			foreach (Color color in canvas)
			{
				arr[index++] = (color.R + color.G + color.B) / 3;
			}
			return arr;
		}

		public void Clear(Color clearColor)
		{
			for (int i = 0; i < rowsAmount; ++i)
			{
				for (int j = 0; j < colsAmount; ++j)
				{
					canvas[i, j] = clearColor;
				}
			}
		}
		public void Clear()
		{
			Clear(Color.Black);
		}

		protected void OnCellColorChanged(CellColorChangedEventArgs args)
		{
			CellColorChanged?.Invoke(this, args);
		}
		protected void OnGridSizeChanged(EventArgs args)
		{
			GridSizeChanged?.Invoke(this, args);

			this.cellWidth = width / colsAmount;
			this.cellHeight = height / rowsAmount;

			bitmap?.Dispose();
			bitmap = new Bitmap(width, height);
			graphics?.Dispose();
			graphics = Graphics.FromImage(bitmap);
		}
	}
}
