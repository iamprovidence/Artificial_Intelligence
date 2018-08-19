class Explosive extends Object
{
  // CONSTRUCTORS
  Explosive(){}
  Explosive(color objectColor, float healthEffects)
  {
    super(objectColor, healthEffects);
  }
  Explosive(float healthEffects)
  {
    super(color(255, 0, 0), healthEffects);
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);
  }
  Object copy()
  {
    return new Explosive(objectColor, healthEffects);
  }
}
