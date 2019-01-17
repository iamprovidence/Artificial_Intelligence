class Background
{
  // CONST
  private final float groundHeight = 40;
  // FIELDS
  private PImage background;
  private PImage ground;
  private PFont font;
  // CONSTRUCTORS
  Background(PImage background, PImage ground, PFont font)
  {
    this.background = background;
    this.ground = ground;
    this.font = font;
  }
  // METHODS
  void show()
  {
    image(ground, 0, height - groundHeight, width, groundHeight);
  }
  boolean collided(Bird bird) 
  {
    return bird.y > height - groundHeight;
  }
  PImage getBackground()
  {
    return background;
  }  
  PFont getFont()
  {
    return font;
  }
}
