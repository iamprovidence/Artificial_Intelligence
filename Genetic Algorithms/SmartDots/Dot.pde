class Dot
{
  // FIELDS
  private Level level;
  private Brain brain;
  
  private PVector position;
  private PVector velocity;
  private PVector acceleration;
  
  private float fitness;
  private int dotSize;
  private int dotSizeChanges;
  
  private boolean isAlive;
  private boolean isGoalReached;  
  private boolean isTheBest;//true if this dot is the best dot from the previous generation
  private boolean hitTheObstacle;
  private boolean hitEdge;
  private boolean noMoveLeft;

  // CONSTRUCTORS
  Dot(Level currentLevel)
  {
    // start the dots ...
    // with 500 moves max ...
    brain = new Brain(500);
    // ...at the bottom of the window ...
    position = new PVector(width / 2, height - 10);
    // ... with a no velocity or acceleration
    velocity = new PVector(0, 0);
    acceleration = new PVector(0, 0);
    
    fitness = 0;
    dotSize = 5;
    dotSizeChanges = 2;
    isAlive = true;
    isGoalReached = false;
    isTheBest = false;
    hitTheObstacle = false;
    hitEdge = false;
    noMoveLeft = false;
    
    setLevel(currentLevel);
  }
  void setLevel(Level currentLevel)
  {
    level = currentLevel;
  }

  // METHODS
  void show()
  {
    if(isTheBest)
    {
      fill(0, 255, 0); // green
      stroke(0);
      ellipse(position.x, position.y, dotSize + dotSizeChanges, dotSize + dotSizeChanges);      
    }
    else if(!isAlive)
    {
      fill(150);// fully gray
      stroke(150);
      ellipse(position.x, position.y, dotSize - dotSizeChanges, dotSize - dotSizeChanges);
    }
    else // regular dot
    {
      fill(0); // fully black
      stroke(0);
      ellipse(position.x, position.y, dotSize, dotSize);
    }
  }
  void move()
  {
    velocity.add(acceleration);
    velocity.limit(5);
    position.add(velocity);
    acceleration = brain.nextMove();
  }
  void checkState()
  {
    if (nearGoal()) // if reached goal
    {
      isGoalReached = true;
    }
    else if (noMovesLeft() || nearEdges() || hitObstacle())
    {
      isAlive = false;
    }
  }
  
  void calculateFitness() 
  {
    // if the dot reached the goal ...
    if (isGoalReached) 
    {
      // ...then the fitness is based on the amount of steps it took to get there
      fitness = 10000.0/(float)(getStep() * getStep());
    } 
    else 
    {
      // ...then the fitness is based on how close it is to the goal
      fitness = 1.0 / (distanceToGoal() * distanceToGoal());
      
      // penalty
      if(hitEdge)
      {
        fitness *= 0.2;
      }
      else if(hitTheObstacle)
      {  
        fitness *= obstacleValue();
      }
      else if(noMoveLeft)
      {  
        fitness *= 0.9;
      }
    }
  }
  void update()
  {
    if(isAlive && !isGoalReached)
    {
      move();
      checkState();
    }
  }
  // GENETIC ALGORITHMS' METHODS
  // clone it 
  Dot clone() 
  {
    Dot clone = new Dot(level);
    clone.brain = brain.copy();
    clone.isTheBest = this.isTheBest;
    return clone;
  }
  Dot growBaby() 
  {
    Dot baby = new Dot(level);
    baby.brain = brain.copy();// baby has the same brain as its parent
    transform(baby);// no any more
    return baby;
  }
  private void transform(Dot dot)
  {
    dot.brain.mutate();
  }
  
  // GET SET
  private boolean nearEdges()
  {
    return hitEdge = position.x < 2|| position.y < 2 || 
      position.x > width - 2 || position.y > height - 2;
  }
  private boolean noMovesLeft()
  {
    return noMoveLeft = acceleration == null;
  }
  private boolean hitObstacle()
  {
    Rect[] obstacles = level.getObstacles();
    for(int i = 0; i < obstacles.length; ++i)
    {
      if(obstacles[i].isPointInZone(position.x, position.y))
      {
        return hitTheObstacle = true;
      }
    }
    return hitTheObstacle = false;
  }
  private float obstacleValue()
  {
    Rect[] obstacles = level.getObstacles();
    for(int i = 0; i < obstacles.length; ++i)
    {
      if(obstacles[i].isPointInZone(position.x, position.y))
      {
        return obstacles[i].getValue();
      }
    }
    return 1.0;
  }
  private boolean nearGoal()
  {
    return distanceToGoal() < level.getGoalRadius();
  }
  private float distanceToGoal()
  {
    return dist(position.x, position.y, level.getGoal().x, level.getGoal().y);
  }
  boolean isAlive()
  {
    return isAlive;
  }
  boolean isGoalReached()
  {
    return isGoalReached;
  }
  void setAsTheBest()
  {
    isTheBest = true;
  }
  float getFitness()
  {
    return fitness;
  }
  int getStep()
  {
    return brain.getStep();
  }
}
