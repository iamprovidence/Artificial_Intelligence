abstract class Object
{  
  // CONST
  final float size = 5;
  // FIELDS
  protected float x;
  protected float y;
  protected float healthEffects;
  protected color objectColor;
  protected Window window;
  // CONSTRUCTORS
  // needs to registrate
  Object()
  {
    this.objectColor = color(0);
    this.healthEffects = 0;
    this.window = null;
  }
  Object(color objectColor, float healthEffects, Window window)
  {
    this.objectColor = objectColor;
    this.window = window;
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
    this.x = random(window.minX(), window.maxX());
    this.y = random(window.minY(), window.maxY());
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
  color getColor()
  {
    return objectColor;
  }
}
