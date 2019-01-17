class Pipe
{
  // CONST
  private static final float pipeWidth = 60;
  private final float speedIncreaseTime = 500;
  private final float pipeGap = 100;
  
  // FIELDS
  private float top;
  private float bottom;
  private float x;
  private float speed;
  private PImage topPipe;
  private PImage bottomPipe;
  // CONSTRUCTORS
  Pipe(PImage topPipe, PImage bottomPipe)
  {
    this.top = random(pipeGap, height - pipeGap);
    this.bottom = top + pipeGap;
    this.x = width;
    this.speed = 5;
    this.topPipe = topPipe;
    this.bottomPipe = bottomPipe;
  }
  // METHODS
  float gapStartY()
  {
    return top;
  }
  void show()
  {
    /*
    // collision zone
    fill(255);
    rect(this.x, 0, this.pipeWidth, this.top);
    rect(this.x, this.bottom, this.pipeWidth, height);
    */
    
    image(topPipe, x, 0, pipeWidth, top);
    image(bottomPipe, x, bottom, pipeWidth, height);
  }
  void update()
  {
    this.x -= this.speed;
    if (frameCount % speedIncreaseTime == 0) ++speed;
  }
  boolean outOfScreen()
  {
    return this.x < - pipeWidth;
  }
  
  boolean collided(Bird bird) 
  {
    return (bird.y < this.top || bird.y > this.bottom) // less than top or greater than bottom
          && bird.x > this.x && bird.x < this.x + this.pipeWidth; 
  }
}
