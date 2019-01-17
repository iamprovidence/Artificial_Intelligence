class Bird
{
  // CONST
  private final float birdSize = 30;
  
  // FILEDS
  private float x;
  private float y;
  private float gravity;
  private float velocity;
  private float jump;
  private boolean isAlive;
  
  private float fitness;// how far you flown
  private float surviveTimes;// more generation you survive, better you are
  
  private ImageAnimator images;
  private NeuralNetwork brain; 
  // CONSTRUCTORS
  Bird(ImageAnimator img)
  {
    x = 25;
    y = height/2;
    gravity = 0.9;
    velocity = 0;
    jump = 4;
    isAlive = true;
    
    fitness = 0;
    surviveTimes = 0;
    
    images = img;
    
    // int inputAmount, int[] hiddenAmount, int outputAmount
   
    // 4 input 
    // - y location of the bird
    // - velocity of the bird
    // - x location of the closest pipe
    // - y location of the closest pipe's gap
    
    // 2 hidden layer with 4 and 2 neurons
    
    // 1 output
    // - jump or not(> 0.5 perform jump)
    brain = new NeuralNetwork(4, new int[] { 4, 2 }, 1);
  }
  // METHODS
  Bird child()
  {
    Bird clone = new Bird(this.images);
    clone.brain = this.brain.copy();
    clone.surviveTimes = 0;
    return clone;
  }
  void mutate(float min, float max, float chance)
  {
    this.brain.mutate(min, max, chance);
  }
  void reset()
  {
    x = 25;
    y = height/2; 
    brain.randomize(-1, 1);
    isAlive = true;
    fitness = 0;
    surviveTimes += 0.01;
  }
  void show()
  {    
    if (!isAlive) return;
    /* 
    collision zone
    fill(255);
    ellipse(this.x, this.y, birdSize, birdSize);
    */
    
    image(images.nextImage(), x-birdSize/2, y-birdSize/2, birdSize, birdSize);
  }
  boolean think(ArrayList<Pipe> pipes)
  {
    boolean isPipeEmpty = pipes.isEmpty();
    // find closest pipe
    int closestPipeIndex = -1;
    if (!isPipeEmpty)
    {
      float closestDistance = (float)Double.POSITIVE_INFINITY;
      for (int i = 0; i < pipes.size(); ++i)
      {
        float currentDistance = (pipes.get(i).x + Pipe.pipeWidth) - this.x;
        if (currentDistance < closestDistance && currentDistance > 0)
        {
          closestPipeIndex = i; 
          closestDistance = currentDistance;
        }
      }
    }
    // 4 input 
    // - y location of the bord
    // - velocity of the bird
    // - x location of the closest pipe
    // - y location of the closest pipe's gap
    // inputs are between 0 and 1
    float birdY = this.y/height;
    float velocity = this.velocity/10;
    float pipeX = isPipeEmpty ? 0 : pipes.get(closestPipeIndex).x/width;
    float pipeGapY = isPipeEmpty ? 0 : pipes.get(closestPipeIndex).gapStartY()/height;
    
    // 1 output
    // - jump or not(> 0.5 perform jump) 
    return this.brain.guess(new float[] { birdY, velocity, pipeX, pipeGapY })[0] > 0.5;
  }
  void update(Pipes pipes, Background background)
  {
    if (!isAlive) return;
    fitness += 0.1;
    
    this.velocity += this.gravity; 
    this.velocity *= 0.9;
    this.y += this.velocity;
    
    this.y = constrain(this.y, 10, height);
    
    // jump
    if (think(pipes.pipes()))
    {
      this.velocity -= this.jump; 
    }
    
    isAlive = !(pipes.collided(this)||background.collided(this));
  }
  // GET SET
  boolean isAlive() { return isAlive; }
  float getFitness() { return fitness + surviveTimes; }
}
