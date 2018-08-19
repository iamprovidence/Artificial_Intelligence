class Brain
{
  // CONST
  final float mutationRate = 0.01;// chance for liking to slightly change   
  // FIELDS
  private Objects objectsToCollect;
  private ArrayList<Object> objectType;
  private FloatList liking;
  
  // CONSTRUCTORS
  Brain()
  {
    objectsToCollect = new Objects();
    objectType = new ArrayList<Object>(2);
    liking = new FloatList(2);
  }
  // METHODS
  void infoAboutObject(Objects objects)
  {
    this.objectsToCollect = objects;
  }
  void goFor(Object o)
  {
    objectType.add(o);
    // you dont know what you like and what not
    this.liking.append(random(-1, 1));
  }

  // GET SET
  int getObjectsAmount()
  {
    return objectsToCollect.size();
  }
  Objects getObjectsToCollect()
  {
    return objects;
  }
  void setLiking(Object type, float likingAmount)
  {
    // search for the same type
    for(int i = 0; i < objectType.size(); ++i)
    {
      if(objectType.get(i).getClass().equals(type.getClass()))
      {
        liking.add(i, likingAmount);
      }
    }
  }
  
  float getLikingByType(Object type)
  {
    // search for the same type
    for(int i = 0; i < objectType.size(); ++i)
    {
      if(objectType.get(i).getClass().equals(type.getClass()))
      {
        // return liking 
        return liking.get(i);
      }
    }
    // there is no such an object
    return -100;
  }
  Brain clone()
  {
    Brain clone = new Brain();
    clone.objectsToCollect = this.objectsToCollect;
    clone.objectType = this.objectType;
    clone.liking = this.liking;
    return clone;
  }
  Brain mutate()
  {
    for(int i = 0; i < liking.size(); ++i)
    {
      if(random(1) < mutationRate)// a little chance
      {
        liking.add(i, random(-0.1, 0.1));
      }
    }
    return this;
  }
}
