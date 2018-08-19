class Population
{
  // FIELDS
  private int amount;
  private ArrayList<Face> faces;
  private float timer;
  // CONSTRUCTORS
  Population(int amount)
  {
    this.amount = amount;
    faces = new ArrayList<Face>(amount);
    timer = 5;
  }
  // METHODS
  void add(Face f)
  {
    if(faces.size() < amount)
    {
      faces.add(f);
    }
  }
  void update()
  {
    for(int i = 0; i < faces.size(); ++i)
    {
      faces.get(i).update();
    }
    fill(255, 0, 0);
    text("You preferences after: " + timer, 15, height - 20);
    timer -= 0.01;
    
    if(timer <= 0)
    {
      timer = 5;
      showNextImage();
    }
  }

  void showNextImage()
  {
    /*
    1. find the image with best scores 
      in way comparing two images and get the winner with better score
      we would lose data if comparing two user preferred image
      but we also would save unpreferred genome for purpose to choose them in future
    
    2. reproduction
      for each do crossover with random neighbour
      fill array to needed amount, if can not clone random one
      slightly mutate all of them  
    */
    // 1
    ArrayList<Face> userPreferredFaces = new ArrayList<Face>(floor(amount/2));
    for(int i = 0; i < amount; ++i)
    {
      if(faces.get(i).getScore() > faces.get((i+1)%amount).getScore())
      {
        userPreferredFaces.add(faces.get(i));
      }
      else
      {
        userPreferredFaces.add(faces.get((i+1)%amount));
      }      
    }
    
    // 2
    // crossover
    ArrayList<Face> child = new ArrayList<Face>(amount);
    int preferredIndex = 0;
    // while array is not full
    while(child.size() != amount)
    {
      // if there are elements in preffered array that we dont see do crossover
      if(preferredIndex < userPreferredFaces.size())
      {
        int randomNeighbourIndex;
        // try to get random neighbour
        do
        {
          randomNeighbourIndex = floor(random(userPreferredFaces.size()));
        }
        while(randomNeighbourIndex == preferredIndex);
        
        child.add(userPreferredFaces.get(preferredIndex).crossover(userPreferredFaces.get( randomNeighbourIndex )));
        ++preferredIndex;        
      }
      else // loop through all preferred, clone random ones
      {
        child.add(userPreferredFaces.get(floor(random(userPreferredFaces.size()))).clone());
      }
    }
    
    // mutate
    for(int i = 0; i < child.size(); ++i)
    {
      child.get(i).mutate().setX(faces.get(i).getX());      
      // and finally, sets new population
      faces.set(i, child.get(i));
    }
  }
}
