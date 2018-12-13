class Box extends Object
{
  // CONSTRUCTORS
  Box()
  {
    // need to registrate    
  }
  Box(color objectColor, Window window)
  {
    super(objectColor, random(-1, 1), window);
  }
  Box(Window window)
  {
    super(color(0, 0, 255), random(-1, 1), window);
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);
  }
  Object copy()
  {
    return new Box(objectColor, window);
  }
  void setRandomPosition()
  {
    super.setRandomPosition();
    // box can contain anything
    this.healthEffects = random(-1, 1);
  }
}
