abstract class Object
{  
  // CONST
  final float size = 5;
  // FIELDS
  protected float x;
  protected float y;
  protected float healthEffects;
  protected color objectColor;
  // CONSTRUCTORS
  Object()
  {
    this.objectColor = color(0);
    this.healthEffects = 0;
  }
  Object(color objectColor, float healthEffects)
  {
    this.objectColor = objectColor;
    setRandomPosition();
    this.healthEffects = healthEffects;
  }
  
  // METHODS
  protected abstract void applyStyle();
  void show()
  {
    ellipseMode(CENTER);
    applyStyle();
    ellipse(x, y, size, size);    
  }
  
  boolean checkCollision(Rocket r)
  {
    return dist(r.position.x, r.position.y, x, y) < r.getRadius();
  }
  void setRandomPosition()
  {
    this.x = random(width);
    this.y = random(height);
  }
  abstract Object copy();
  // GETS

  PVector getPosition()
  {
    return new PVector(this.x,this.y);
  }
  float HealthEffects()
  {
    return healthEffects;
  }
}
