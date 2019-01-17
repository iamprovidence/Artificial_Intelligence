class Population
{
  // FIELDS
  private int size;
  private int generation;
  private float mutationRate;
  
  private Bird[] birds;
  
  private ImageAnimator regularBirdAnim;
  
  private float currentDistance;
  private float maxDistance;
  private int aliveAmount;
  // CONSTRUCTORS
  Population(int size, float mutationRate)
  {
    this.regularBirdAnim = new ImageAnimator(20)
              .add(loadImage("yellow_up.png"))
              .add(loadImage("yellow_mid.png"))
              .add(loadImage("yellow_down.png"));
    this.size = size;
    this.generation = 0;
    this.mutationRate = mutationRate;
    
    this.birds = new Bird[size];
    for (int i = 0; i < size; ++i)
    {      
      this.birds[i] = new Bird(regularBirdAnim);
    }
    
    this.currentDistance = 0;
    this.maxDistance = 0;
    this.aliveAmount = 0;
  }
  // METHODS
  void showInfo()
  {
    fill(0);
    
    text("generation = " + generation, 10, height - 22);
    text("size = " + size, 10, height - 12);
    text("mutation rate = " + mutationRate, 10, height - 2);
    
    text("current distance = " + nfc(currentDistance, 2), width/2, height - 22);
    text("max distance = " + nfc(maxDistance, 2), width/2, height - 12);
    text("alive = " + aliveAmount, width/2, height - 2);
  }
  void show()
  {
    for (int i = 0; i < size; ++i)
    {      
      birds[i].show();
    }
  }
  void update(Pipes pipes, Background background)
  {
    currentDistance += 0.1;
    
    int deadAmount = 0;
    for (int i = 0; i < size; ++i)
    {      
      birds[i].update(pipes, background);
      
      if(!birds[i].isAlive()) ++deadAmount;
    }
    aliveAmount = size - deadAmount;
    // if all are dead
    if (deadAmount == size)
    {
      nextGeneration();
      reset();
      pipes.reset();
    }
  }
  void reset()
  {
    if (maxDistance < currentDistance) maxDistance = currentDistance;
    this.currentDistance = 0;
    for (int i = 0; i < size; ++i)
    {      
      birds[i].reset();
    }
  }
  void nextGeneration()
  {
    ++generation;
    
    // selection
    // tournament selection, get 2 random ones and compare them
    int elitistAmount = size / 3;
    int picked = 0;
    Bird[] champion = new Bird[size];
    
    // fill only 1/3 of it
    while(elitistAmount != picked)
    {
      // get two random indices
      int f = (int)random(size);
      int s;
      do
      {
        s = (int)random(size);
      }while(f == s);
      
      // compare them
      if (birds[f].getFitness() < birds[s].getFitness()) f = s;
      
      // add it
      champion[picked] = birds[f];
      ++picked;
    }
    
    // fill last array part with mutated child
    // from best parent
    
    // go through parents by circle
    int index = 0;
    while(picked != size)
    {
      // add child
      champion[picked] = champion[index].child();
      champion[picked].mutate(-0.1, 0.1, mutationRate);// mutate child
      ++picked;
     
      // next parent in cirlce
      ++index;
      index %= elitistAmount;
    }    
    
    // now this array is current generation
    this.birds = champion;
  }
}
