class Population
{
 // FIELDS
 private Dot[] dots;
 private float fitnessSum;
 private int generationCount;
 private int bestDotIndex;
 private int minStep;
 private Level level;
 
 // CONSTRUCTORS
 Population(int size, Level currentLevel)
 {
   fitnessSum = 0;
   generationCount = 1;
   bestDotIndex = -1;
   minStep = 9999;
   level = currentLevel;
   
   dots = new Dot[size];
   for(int i = 0; i < dots.length; ++i)
   {
     dots[i] = new Dot(level);
   }
   
 }
 void SetLevel()
 {
   for(int i = 0; i < dots.length; ++i)
   {
     dots[i].setLevel(level);
   }
 }
 // METHODS
 void run()
 {
   if (allDotsDead()) 
   {
    //genetic algorithm
    calculateFitness();
    naturalSelection();
   } 
   else 
   {
    //if any of the dots are still alive then update and then show them
    update();
    show();
  }
 }
 void show()
 {
   // TEXT
   textAlign(LEFT, BOTTOM);
   textSize(14);
   fill(12);
   text("Generation № " + generationCount + " Step " + minStep, 10, height - 10); // left bottom corner
   
   // DOTS
   for(int i = 0; i < dots.length; ++i)
   {
     dots[i].show();
   }
 }
 void update()
 {
   for(int i = 0; i < dots.length; ++i)
   {
     dots[i].update();
   }
 }
 
 void calculateFitness() 
 {
    for (int i = 0; i < dots.length; ++i) 
    {
      dots[i].calculateFitness();
    }
  }
  void calculateFitnessSum() 
  {
    fitnessSum = 0;
    for (int i = 0; i< dots.length; ++i) 
    {
      fitnessSum += dots[i].getFitness();
    }
  }
  
  boolean allDotsDead() 
  {
    for (int i = 0; i< dots.length; ++i) 
    {
      if (dots[i].isAlive() && !dots[i].isGoalReached()) 
      { 
        return false;
      }
    }
    return true;
  }
  // finds the dot with the highest fitness and sets it as the best dot
  void setBestDot()
  {
    int maxIndex = 0;
    for (int i = 0; i< dots.length; ++i) 
    {
      if (dots[i].getFitness() > dots[maxIndex].getFitness()) 
      {
        maxIndex = i;
      }
    }

    bestDotIndex = maxIndex;
    dots[bestDotIndex].setAsTheBest();
    
    // if this dot reached the goal ...
    if (dots[bestDotIndex].isGoalReached()) 
    {
      // .. then reset the minimum number of steps it takes to get to the goal 
      minStep = dots[bestDotIndex].getStep();
      level.isLevelPased(minStep);
      if(!level.allCoinsCollected())
      {
        level.collectCoin();
      }
    }
  }
  // this function works by randomly choosing a value between 0 and the sum of all the fitnesses
  // then go through all the dots and add their fitness to a running sum 
  // and if that sum is greater than the random value generated that dot is chosen
  //
  // since dots with a higher fitness function add more to the running sum then they have a HIGHER chance of being chosen
  Dot selectParent() 
  {
    float rand = random(fitnessSum);

    float runningSum = 0;

    for (int i = 0; i < dots.length; ++i) 
    {
      runningSum += dots[i].getFitness();
      if (runningSum > rand) 
      {
        return dots[i];
      }
    }

    //should never get to this point

    return null;
  }
  void naturalSelection() 
  {
    ++ generationCount;
    
    Dot[] newDots = new Dot[dots.length];//next gen
    setBestDot();
    calculateFitnessSum();

    //the champion lives on ... and has no child
    Dot bestDot = dots[bestDotIndex].clone();
    
    for (int i = 0; i < newDots.length; ++i)
    {
      // get baby from selected parent
      newDots[i] = selectParent().growBaby();
    }
    // put best dot in the end, so it will be always visible
    newDots[newDots.length - 1] = bestDot;
    // parents pass away, new generation come
    dots = newDots.clone();
  }
}
