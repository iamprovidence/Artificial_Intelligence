class Resource extends Object
{
  // CONSTRUCTORS
  Resource()
  {
    // needs to registrate
  }
  Resource(color objectColor,float healthEffects, Window window)
  {
    super(objectColor, healthEffects, window);
  }
  Resource(float healthEffects, Window window)
  {
    super(color(0, 255, 0), healthEffects, window);
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);    
  }
  Object copy()
  {
    return new Resource(objectColor, healthEffects, window);
  }
}
