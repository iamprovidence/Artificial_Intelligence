class ObjectToCollectStatistic
{
  // FIELDS
  private Window window;
  private Objects objects;
  // CONSTRUCTORS
  ObjectToCollectStatistic(Objects objects, Window window)
  {
    this.objects = objects;
    this.window = window;
  }
  // METHODS  
  void show()
  {
    textSize(25);
    fill(0);
    textAlign(CENTER, CENTER);
    text("Object Statistic", window.centerX(), window.minY() + 20);
    
    HashMap<Class, ObjectInfo> statistic = objects.infoAboutObjects();
    float blockWidth = window.width() / statistic.size();
    
    float average = 0;
    for (Map.Entry<Class, ObjectInfo> item : statistic.entrySet())
    {
      average += item.getValue().getCollected();
    }
    average /= statistic.size();
    
    int i = 0;
    noStroke();
    for (Map.Entry<Class, ObjectInfo> item : statistic.entrySet()) 
    {
      fill (item.getValue().getColor());
      
      text (item.getValue().getCollected() + " : " + item.getValue().getAmount(), window.minX() + blockWidth*i + blockWidth/2, window.minY() + 60);
      float blockHeight = (window.maxY() - item.getValue().getCollected()/average * (window.height()/2)+40);
      rect (window.minX() + blockWidth*i, blockHeight, window.minX()+ blockWidth*(i+1), window.maxY());

      ++ i;
    }
  }    
}
