class Brain
{
  // CONST
  final float mutationRate = 0.01;// chance for liking to slightly change   
  // FIELDS
  private Objects objectsToCollect;
  private HashMap<Class, Float> objectLiking;
  
  // CONSTRUCTORS
  Brain()
  {
    objectsToCollect = new Objects();
    objectLiking = new HashMap<Class, Float>();
  }
  // METHODS
  void infoAboutObject(Objects objects)
  {
    this.objectsToCollect = objects;
  }
  void goFor(Object type)
  {
    // you dont know what you like and what not
    objectLiking.put(type.getClass(), random(-1, 1));
    objectsToCollect.registrateType(type);
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
  void setLiking(Class type, float likingAmount)
  {
    if (objectLiking.containsKey(type))
    {
      objectLiking.put(type, objectLiking.get(type) + likingAmount);
    }
  }
  
  float getLikingByType(Class type)
  {
    // search for the same type
    if (objectLiking.containsKey(type))
    {
      return objectLiking.get(type);
    }
    // there is no such an object
    return -1;
  }
  Brain clone()
  {
    Brain clone = new Brain();
    clone.objectsToCollect = this.objectsToCollect;
    clone.objectLiking = new HashMap<Class, Float>(this.objectLiking);
    return clone;
  }
  Brain mutate()
  {
    for (Map.Entry<Class, Float> item : objectLiking.entrySet())
    {
      if(random(1) < mutationRate)// a little chance
      {
        objectLiking.put(item.getKey(), item.getValue() + random(-0.1, 0.1));
      }
    }
    return this;
  }
  HashMap<Class, Float> getObjectLiking()
  {
    return objectLiking;
  }
}
