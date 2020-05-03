namespace digitRecognizer.Controls.Grid
{
	public class CellColorChangedEventArgs
	{
		public float X { get; private set; }
		public float Y { get; private set; }
		public float Width { get; private set; }
		public float Height { get; private set; }
		public System.Drawing.Color Color { get; private set; }

		public CellColorChangedEventArgs(float x, float y, float width, float height, System.Drawing.Color color)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
			this.Color = color;
		}
	}
}
