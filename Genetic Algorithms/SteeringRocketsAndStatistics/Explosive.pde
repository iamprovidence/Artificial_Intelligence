class Explosive extends Object
{
  // CONSTRUCTORS
  Explosive()
  {    
    // need to registrate
  }
  Explosive(color objectColor, float healthEffects, Window window)
  {
    super(objectColor, healthEffects, window);
  }
  Explosive(float healthEffects, Window window)
  {
    super(color(255, 0, 0), healthEffects, window);
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);
  }
  Object copy()
  {
    return new Explosive(objectColor, healthEffects, window);
  }
}
