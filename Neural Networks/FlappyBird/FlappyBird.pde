int populationSize = 500;
float mutationRate = 0.05;

Population birds;
Pipes pipes;
Background background;

void setup()
{
  size(288, 512);// the same as background image size
  birds = new Population(populationSize, mutationRate);
  pipes = new Pipes(loadImage("pipe_down.png"), loadImage("pipe_up.png"));
  background = new Background(loadImage("background.png"), loadImage("base.png"), loadFont("AgencyFB-Bold-48.vlw"));
}

void draw()
{
    background(background.getBackground());// back    
    
    // updating everything
    birds.update(pipes, background);
    birds.show();

    pipes.update(); 
    pipes.show();
    
    // grass are showing upon pipe    
    background.show();
    
    // show population info
    birds.showInfo();
}
