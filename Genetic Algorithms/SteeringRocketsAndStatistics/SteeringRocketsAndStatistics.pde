// imports
import java.util.Map;

// CONST
final int populationStartSize = 5;
final int explosiveAmount = 100;
final int resourceAmount = 50;
final int boxAmount = 25;

// VARIABLES
Population population;
Objects objects;
MyGrid grid;

RocketStatistic rocketStatistic;
PopulationStatistic populationStatistic;
ObjectToCollectStatistic objectStatistic;

void setup()
{
  fullScreen(FX2D);
  //size(480, 300, FX2D);
  
  grid = new MyGrid(2, 2);
  grid.setWindowColor(0, 0, 50);  
  grid.setWindowColor(1, 0, 230);
  grid.setWindowColor(0, 1, 40);
  grid.setWindowColor(1, 1, 30);
  
  population = new Population(populationStartSize, grid.getWindow(0, 0));
  
  objects = new Objects();
  // The rockets receive from the authorities ...
  // ... information about to the location of the objects
  population.infoAboutObject(objects);
  // ... order what objects to check
  population.goFor(new Box());
  population.goFor(new Resource());
  population.goFor(new Explosive());
  
  objects.add(boxAmount, new Box(color(50, 230, 255), grid.getWindow(0, 0)));
  objects.add(resourceAmount, new Resource(0.1, grid.getWindow(0, 0)));
  objects.add(explosiveAmount, new Explosive(-0.2, grid.getWindow(0, 0)));  
  
  // Statistics
  rocketStatistic = new RocketStatistic(population.getRockets(), objects, grid.getWindow(0, 1));
  objectStatistic = new ObjectToCollectStatistic(objects, grid.getWindow(1, 0));
  populationStatistic = new PopulationStatistic(population, grid.getWindow(1, 1));
}

void draw()
{  
  grid.show();
  
  population.update();
  
  objects.show();    
  
  rocketStatistic.show();
  populationStatistic.update();
  objectStatistic.show();
}
