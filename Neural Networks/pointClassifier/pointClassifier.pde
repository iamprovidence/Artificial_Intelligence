Line line;
Neuron parceptron;
Point[] points;
int iteration = 0;

void setup()
{
  size(800, 400);
  line = new Line(width / 2, width);
  parceptron = new Neuron();
  points = new Point[100];
  for(int i = 0; i < points.length; ++i)
  {
    float x = random(width/2, width);
    float y = random(0, height);
    points[i] = new Point(x, y, line.category(x, y));
  }
}
void draw()
{
  background(200);
  fill(0);
  text(iteration, 10, 10);
  // border
  strokeWeight(5);
  stroke(0);
  line(width/2, 0, width/2, height);
  
  line.show();
  
  parceptron.show(0, 0, width/2, height);
  
  for(Point point: points)
  {
    point.show();
    float[] inputs = { point.X(), point.Y() };
    if(parceptron.guess(inputs) == point.Category())
    {
      fill(0, 255, 0);
    }
    else
    {
      fill(255, 0, 0);
    }
    
    noStroke();
    ellipse(point.X(), point.Y(), 6, 6);
  }
  
  strokeWeight(2);
  stroke(255, 255, 0);
  line(width/2, parceptron.guessY(width/2), width, parceptron.guessY(width));
}
void mouseClicked()
{
  for(Point point: points)
  {
    float[] inputs = { point.X(), point.Y() };
    parceptron.train(inputs, point.Category());
  }
  ++ iteration;
}
