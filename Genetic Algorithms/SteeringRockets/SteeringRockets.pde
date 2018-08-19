Population rockets;
Objects objects;

void setup()
{
  size(480, 300);
  rockets = new Population(5);
  objects = new Objects();
  objects.add(25, new Box(color(50, 230, 255)));
  objects.add(50, new Resource(0.1));
  objects.add(100, new Explosive(-0.2));
  
  // The rockets receive from the authorities ...
  // ... information about to the location of the objects
  rockets.infoAboutObject(objects);
  // ... order what objects to check
  rockets.goFor(new Box());
  rockets.goFor(new Resource());
  rockets.goFor(new Explosive());
}

void draw()
{
  background(50);
  
  rockets.update();
  
  objects.show();
}
