class RocketStatistic
{
  // CONST
  final private int rocketWindowInfoSize = 340;
  // FIELDS
  private Window window;
  private Objects objects;
  private ArrayList<Rocket> rockets;
  // CONSTRUCTORS
  RocketStatistic (ArrayList<Rocket> rockets, Objects objects, Window window)
  {
    this.window = window;
    this.objects = objects;
    this.rockets = rockets;
  }
  // METHODS
  void show()
  {
    textSize(25);
    fill(240);
    textAlign(CENTER, CENTER);
    text("Rocket Statistic", window.centerX(), window.minY() + 20);
    
    int sizeY = 35;
    int infoInOneColumn = (int)window.height() / sizeY;
    int colAmount = (int)window.width() / rocketWindowInfoSize;
    
    for(int c = 0; c < colAmount; ++c)
    {
      for (int i = c*infoInOneColumn; i < rockets.size() && i < infoInOneColumn*(c+1); ++i)
      {      
        showInfoAboutRocket(i, 10 + c*(window.width()/2), sizeY*((i+1)-(c*infoInOneColumn)));
      }
    }
  }  
  void showInfoAboutRocket(int rocketId, float posX, float posY)
  {
    RocketInfo info = rockets.get(rocketId).getInfo();
    
    // rocket view
    strokeWeight(1);
    stroke(255);
    fill(info.rocketColor);
    triangle(window.minX() + posX, posY + 10, window.minX() + posX, posY + 20, window.minX() + posX + 20, posY+15);
    // health
    textSize(15);
    fill(info.rocketColor);
    text(info.health , window.minX() + posX + 60, window.minY() + posY+15);
    // see distance
    textSize(15);
    fill(info.lightColor);
    text(info.seeDistance , window.minX() + posX + 110, window.minY() + posY+15);
  
    // liking
    int i = 0;
    for (Map.Entry<Class, Float> item : info.objectLiking.entrySet()) 
    {
      fill(objects.infoAboutObjects().get(item.getKey()).getColor());
      text (nfc(item.getValue(), 2), window.minX() + (i*50) + posX + 190, window.minY() + posY+15);
      ++i;
    }
  }
}
