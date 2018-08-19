class Box extends Object
{
  // CONSTRUCTORS
  Box(color objectColor)
  {
    super(objectColor, random(-1, 1));
  }
  Box()
  {
    super(color(0, 0, 255), random(-1, 1));
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);
  }
  Object copy()
  {
    return new Box(objectColor);
  }
  void setRandomPosition()
  {
    this.x = random(width);
    this.y = random(height);
    // box can contain anything
    this.healthEffects = random(-1, 1);
  }
}
