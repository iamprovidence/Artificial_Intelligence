using System.Drawing;

namespace digitRecognizer.Models.Controls
{
	public partial class NumberControl : System.Windows.Forms.UserControl
	{
		// FIELDS
		Color color;
		Graphics graphics;

		// CONSTRUCTORS
		public NumberControl()
		{
			InitializeComponent();

			graphics = colorPnl.CreateGraphics();
			graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
		}

		// EVENT
		public event System.EventHandler ControlChanged;

		// METHODS
		private void colorPnl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			int radius = System.Linq.Enumerable.Min(new int[2] { colorPnl.Width / 2, colorPnl.Height / 2 });

			using (SolidBrush brush = new SolidBrush(color))
			using (Pen pen = new Pen(Color.Black))
			{
				graphics.FillEllipse(brush, colorPnl.Width / 2 - radius / 2, colorPnl.Height / 2 - radius / 2, radius, radius);
				graphics.DrawEllipse(pen, colorPnl.Width / 2 - radius / 2, colorPnl.Height / 2 - radius / 2, radius, radius);
			}
		}

		// PROPERTIES
		public Color Color
		{
			get
			{
				return color;
			}
			set
			{
				color = value;
				OnControlChanged(System.EventArgs.Empty);
			}
		}
		public int Number
		{
			get
			{



				return int.Parse(numberLbl.Text);
			}
			set
			{
				numberLbl.Text = value.ToString();
				OnControlChanged(System.EventArgs.Empty);
			}
		}
		public double Value
		{
			get
			{
				return double.Parse(valueLbl.Text);
			}
			set
			{
				if (value > 0.75)		Color = Color.Green;
				else if (value > 0.3)	Color = Color.Yellow;
				else if (value > 0)		Color = Color.Red;
				else					Color = Color.White;

				valueLbl.Text = value.ToString();
				OnControlChanged(System.EventArgs.Empty);
			}
		}

		protected void OnControlChanged(System.EventArgs args)
		{
			ControlChanged?.Invoke(this, args);
		}
	}
}
