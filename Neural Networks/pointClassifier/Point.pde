class Point
{
  // FIELDS
  private float x;
  private float y;
  private int category;
  // CONSTRUCTORS
  Point(float x, float y, int category)
  {
    this.x = x;
    this.y = y;
    this.category = category;
  }
  // METHODS
  void show()
  {
    noStroke();
    if(category == 1) fill(0);
    else fill(255);
    
    ellipse(x, y,  10, 10);
  }
  int Category() { return category; }
  float X() { return x; }
  float Y() { return y; }
}
