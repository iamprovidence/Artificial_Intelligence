class Objects
{
  // FIELDS
  private ArrayList<Object> objects;
  // CONSTRUCTORS
  Objects()
  {
    objects = new ArrayList<Object>(50);
  }
  
  // METHODS
  void show()
  {
    for(int i = 0; i < objects.size(); ++i)
    {
      objects.get(i).show();
    }
  }

  void add(int amount, Object object)
  {
    for(int i = 0; i < amount; ++i)
    {
      objects.add(object.copy());
      objects.get(i).setRandomPosition();
    }
  }
  // GETS SETS
  int size()
  {
    return objects.size();
  }
  
  PVector getPosition(int i)
  {
    return objects.get(i).getPosition();
  }
  Object get(int index)
  {
    return objects.get(index);
  }
  float getHealthEffect(int i)
  {
    return objects.get(i).HealthEffects();
  }
}
