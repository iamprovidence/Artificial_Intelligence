class Brain
{
  // FIELDS
  private PVector[] directions;
  private int step;
  private float mutationRate;// chance that any vector in directions gets changed
  int getStep()
  {
    return step;
  }
  
  // CONSTRUCTORS
  Brain(int size, float mutationRate)
  {
    step = 0;
    this.mutationRate = mutationRate;
    directions = new PVector[size];
    for(int i = 0; i < directions.length; ++i)
    {
      directions[i] = PVector.fromAngle(random(2 * PI));
    }
  }
  Brain()
  {
    this(400, 0.01);
  }
  Brain(int size)
  {
    this(size, 0.01);
  }
  Brain(float mumationRate)
  {
    this(400, mumationRate);
  }
  // METHODS
  PVector nextMove()
  {
    if(step < directions.length)
    {
      return directions[step++];
    }
    return null;
  }
  Brain copy() 
  {
    Brain clone = new Brain(directions.length);
    for (int i = 0; i < directions.length; i++) 
    {
      clone.directions[i] = directions[i].copy();
    }
    return clone;
  }
  void mutate() 
  {
    for (int i = 0; i < directions.length; ++i)
    {
      if (random(1) < mutationRate) 
      {
        // set this direction as a random direction 
        directions[i] = PVector.fromAngle(random(2*PI));
      }
    }
  }
}
