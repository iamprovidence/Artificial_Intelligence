class Line
{
  // CONFIG
  private float f(float x)
  {
    // y = m*x + b
    return  0.4*x + 2.3;
  }
  // FIELDS
  private float x1;
  private float y1;
  private float x2;
  private float y2;
  // CONSTRUCTORS
  Line(float x1, float x2)
  {
    this.x1 = x1;
    this.y1 = f(x1);
    this.x2 = x2;
    this.y2 = f(x2);
  }
  // METHODS
  void show()
  {
    stroke(3);
    line(x1, y1, x2, y2);
  }
  int category(float x, float y)
  {
    if(f(x) < y) return 1;
    return -1;
  } 
}
