using System;
using System.Drawing;
using System.Windows.Forms;

namespace digitRecognizer.Controls.Grid
{
	public partial class DrawingGridControl : UserControl
	{
		private bool drawing;
		private bool erasing;

		private readonly Grid grid;

		public DrawingGridControl()
		{
			InitializeComponent();

			drawing = false;
			erasing = false;

			grid = new Grid(rows: 28, cols: 28, width: gridPnl.Width, height: gridPnl.Height);
			grid.CellColorChanged += Grid_CellColorChanged;
		}

		public double[] ToColorDoubleArray()
		{
			return grid.ToColorDoubleArray();
		}

		public void Draw(byte[] colorCodes)
		{
			grid.Draw(colorCodes);
		}

		public void Clear()
		{
			grid.Clear();
			gridPnl.Invalidate();
		}

		private void Grid_CellColorChanged(object sender, CellColorChangedEventArgs e)
		{
			using (Graphics g = gridPnl.CreateGraphics())
			using (SolidBrush brush = new SolidBrush(e.Color))
			{
				g.FillRectangle(brush, e.X, e.Y, e.Width, e.Height);
				g.DrawRectangle(Pens.White, e.X, e.Y, e.Width, e.Height);
			}
		}

		private void gridPnl_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(DefaultBackColor);
			e.Graphics.DrawImage(grid.Show(), 0, 0);
		}
		private void gridPnl_Resize(object sender, EventArgs e)
		{
			grid.Width = gridPnl.Width;
			grid.Height = gridPnl.Height;

			gridPnl.Invalidate();
		}
		private void gridPnl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) drawing = true;
			else if (e.Button == MouseButtons.Right) erasing = true;
		}

		private void gridPnl_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) drawing = false;
			else if (e.Button == MouseButtons.Right) erasing = false;
		}
		private void gridPnl_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (drawing)
				{
					// fill with color
					// central square
					grid.MakeBrighterCellFromPixel(e.X, e.Y);
					// neighbour squares
					grid.MakeBrighterCellFromPixel(e.X + 10, e.Y);
					grid.MakeBrighterCellFromPixel(e.X - 10, e.Y);
					grid.MakeBrighterCellFromPixel(e.X, e.Y + 10);
					grid.MakeBrighterCellFromPixel(e.X, e.Y - 10);
				}
				else if (erasing)
				{
					grid.FillCellFromPixel(e.X, e.Y, Color.Black);
				}
			}
			catch (IndexOutOfRangeException)
			{
				// user still hold mouse but move out panel range
				// ignore
			}
		}
	}
}
