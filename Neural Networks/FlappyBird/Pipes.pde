class Pipes
{
  // CONST  
  private final float distanceBetweenPipe = 50;

  // FIELDS
  private ArrayList<Pipe> pipes;
  private PImage topPipe;
  private PImage bottomPipe;
  // CONSTRUCTORS
  Pipes(PImage topPipe, PImage bottomPipe)
  {
    this.pipes = new ArrayList<Pipe>(10);
    this.topPipe = topPipe;
    this.bottomPipe = bottomPipe;
  }
  // METHODS
  ArrayList<Pipe> pipes()
  {
    return pipes;
  }
  void reset()
  {
    pipes.clear();
  }
  void update()
  {
    if (frameCount % distanceBetweenPipe == 0)
    {
      pipes.add(new Pipe(topPipe, bottomPipe));
    }

    // cleaning sometimes
    if (pipes.size() == 10) this.cleanUp();  
    
    // update each pipe
    for (Pipe pipe : pipes)
    {
      pipe.update();
    }
  }
  boolean collided(Bird bird)
  {
    for (Pipe pipe : pipes)
    {
      // check collision
      if (!pipe.outOfScreen() && pipe.collided(bird)) 
      {
          return true;
      }
    }
    return false;
  }
  void show()
  {
    for (Pipe pipe : pipes)
    {
      if (!pipe.outOfScreen()) pipe.show();
    }
  }

  // remove all pipes which is not showed
  void cleanUp()
  {  
    for (int i = 0; i < pipes.size(); ++i) 
    {
      if (pipes.get(i).outOfScreen()) 
      {
        pipes.remove(i);
        i--;//decrease the counter by one
      }
    }
  }
}
