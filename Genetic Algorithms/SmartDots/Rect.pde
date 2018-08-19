class Rect
{
  // FIELDS
  private float x;
  private float y;
  private float rectWidth;
  private float rectHeight;
  private float value;
  
  // CONSTRUCTORS
  Rect(float x, float y, float rectWidth, float rectHeight, float value)
  {
    this.x = x;
    this.y = y;
    this.rectWidth = rectWidth;
    this.rectHeight = rectHeight;
    this.value = value;
  }
  //METHODS
  void draw()
  {
    fill(0, 0, 255); // blue
    stroke(0);
    rect(x, y, rectWidth, rectHeight);
  }
  boolean isPointInZone(float px, float py)
  {
    return px > x && px < x + rectWidth && py > y && py < y + rectHeight;
  }
  float getValue()
  {
    return value;
  }
}
