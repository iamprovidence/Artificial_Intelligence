class Resource extends Object
{
  // CONSTRUCTORS
  Resource(){}
  Resource(color objectColor,float healthEffects)
  {
    super(objectColor, healthEffects);
  }
  Resource(float healthEffects)
  {
    super(color(0, 255, 0), healthEffects);
  }
  // METHODS
  protected void applyStyle()
  {
    noStroke();
    fill(objectColor);    
  }
  Object copy()
  {
    return new Resource(objectColor, healthEffects);
  }
}
