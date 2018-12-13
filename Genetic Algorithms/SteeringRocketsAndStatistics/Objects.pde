class Objects
{
  // FIELDS
  private ArrayList<Object> objects;  
  private HashMap<Class, ObjectInfo> objectsStatistic;
  // CONSTRUCTORS
  Objects()
  {
    objects = new ArrayList<Object>(50);
    objectsStatistic = new HashMap<Class, ObjectInfo>();
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
    if (objectsStatistic.containsKey(object.getClass()))
    {
      objectsStatistic.get(object.getClass()).setMapAmount(amount);
      objectsStatistic.get(object.getClass()).setColor(object.getColor());
    }
    for(int i = 0; i < amount; ++i)
    {
      objects.add(object.copy());
      objects.get(i).setRandomPosition();
    }
  }
  void registrateType(Object type)
  {
    objectsStatistic.put(type.getClass(), new ObjectInfo(0, 0, type.getColor()));
  }
  void addToCollected(Class type, int value)
  {    
    objectsStatistic.get(type).addToCollectedAmount(value);
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
  HashMap<Class, ObjectInfo> infoAboutObjects()
  {
    return objectsStatistic;
  }
}
