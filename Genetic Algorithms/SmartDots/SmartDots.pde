int speed = 10; // const (0 - 10)
int levelIndex = 1; // 0 - 5 

Population population;
SmartDotsGame game; 

void setup()
{
  size(800, 600);
  frameRate(map(speed, 0, 10, 60, 250));
  
  game = new SmartDotsGame();
  population = new Population(100, game.getLevel(levelIndex));
}

void draw()
{
  background(255);
  game.getLevel(levelIndex).show();
  population.run();
}
