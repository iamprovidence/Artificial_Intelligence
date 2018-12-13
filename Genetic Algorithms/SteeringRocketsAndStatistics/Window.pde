class Window
{
  // FIELDS
  private Point topLeft;
  private Point bottomRight;
  private color backColor;
  // COSTRUCTORS
  Window(Point topLeft, Point bottomRight)
  {
    this.topLeft = topLeft;
    this.bottomRight = bottomRight;
    this.backColor = color(255);
  }
  // METHODS
  void show()
  {
    rectMode(CORNERS);
    strokeWeight(5);
    stroke(51);
    fill(backColor);
    rect(topLeft.x, topLeft.y, bottomRight.x, bottomRight.y);
  }
  void setColor(color windowColor)
  {
    this.backColor = windowColor;
  }
  float minX()
  {
    return topLeft.x;
  }
  float maxX()
  {
    return bottomRight.x;
  }
  float minY()
  {
    return topLeft.y;
  }
  float maxY()
  {
    return bottomRight.y;
  }
  float centerX()
  {
    return (minX() + maxX())/2;
  }
  float centerY()
  {
    return (minY() + maxY())/2;
  }
  float width()
  {
    return abs(bottomRight.x - topLeft.x);
  }
  float height()
  {
    return abs(bottomRight.y - topLeft.y);
  }  
}
