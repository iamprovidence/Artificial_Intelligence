/*
no fitness function
more they live, there more chance to reproduce
*/
class Population
{
  // CONST
  final float chanceToDoClone = 0.0005; // 0.05 %
  // FIELDS
  private ArrayList<Rocket> rockets;
  // CONSTRUCTORS
  Population(int amount)
  {
    rockets = new ArrayList<Rocket>(amount);
    for(int i = 0; i < amount; ++i)
    {
      rockets.add(new Rocket(random(width), random(height)));
    }
  }
  // METHODS
  void update()
  {
    for(int i = 0; i < rockets.size(); ++i)
    {
      rockets.get(i).update();
    }
    cloning();// try it every frame
    // 1 % of the time do cleaning
    if(random(1) < 0.01)
    {
      cleaning();
    }
  }  
  void infoAboutObject(Objects objects)
  {
    for(int i = 0; i < rockets.size(); ++i)
    {
      rockets.get(i).infoAboutObject(objects);
    }
  }
  void goFor(Object object)
  {
    for(int i = 0; i < rockets.size(); ++i)
    {
      rockets.get(i).goFor(object);
    }
  }
  void seeking()
  {
    for(int i = 0; i < rockets.size(); ++i)
    {
      rockets.get(i).seeking();
    }
  }
  void cloning()
  {
    // every lived rocket has 0.05 % chance to do cloning
    // healthier one has better chance, dead one has no chance
    for(int i = 0; i < rockets.size(); ++i)
    {
      if(random(1) < chanceToDoClone * rockets.get(i).getHealth()/3)
      {
        rockets.add(rockets.get(i).clone().mutate());
      }
    }
  }
  void cleaning()
  {
    for (int i = 0; i < rockets.size(); ++i) 
    {
     if (rockets.get(i).isDead()) 
     {
        rockets.remove(i);
        i--;//decrease the counter by one
     }
    }
  }
}
