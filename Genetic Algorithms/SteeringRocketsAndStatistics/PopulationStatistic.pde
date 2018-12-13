class PopulationStatistic
{
  // FIELDS
  private Window window;
  private Population population;
  private ArrayList<Point> graph;
  private int currentSize;
  private int lastPoint;
  // CONSTRUCTORS
  PopulationStatistic(Population population, Window window)
  {
    this.population = population;
    this.currentSize = population.alive();
    this.window = window;
    this.graph = new ArrayList<Point>();
    
    float step = window.centerX() / (window.width()/7);
    for (float i = window.minX()+5; i < window.centerX(); i+= step)
    {
      this.graph.add(new Point(i, window.centerY()));  
    }
    this.lastPoint = graph.size()-1;
    
  }
  // METHODS
  void show()
  {
    // text info
    textSize(25);
    fill(240);
    textAlign(CENTER, CENTER);
    text("Population Statistic", window.centerX(), window.minY() + 20);    
    
    text("Population size: " + population.alive(), window.centerX(), window.minY() + 50);
    
    // graph
    strokeWeight(4);
    stroke(255, 0, 0);
    for (int i = 0; i < graph.size() - 1; ++i)
    {
      line(graph.get(i).x, graph.get(i).y, graph.get(i+1).x, graph.get(i+1).y);
    }
    // last point, little circle in the end
    fill(255, 255, 50);// yellow
    strokeWeight(2);
    ellipse(graph.get(graph.size() - 1).x, graph.get(graph.size() - 1).y, 10, 10);
  }
  void update()
  {
    // if size changed...
    if (currentSize != population.alive())
    {
      // move prev graph point to the left
      for (int i = 1; i < graph.size(); ++i)
      {
        graph.get(i-1).y = graph.get(i).y;
      }      
      // change last point
      int climb = (population.alive() - currentSize ) > 0 ? 5 : -5;
      this.graph.set(lastPoint ,new Point(window.centerX(), window.centerY() - climb));
      // update currentSize value
      currentSize = population.alive();
    }
    normalize();
    show();
  }  
  // try to hold graph always at the middle
  private void normalize()
  {
    if (graph.get(lastPoint).y != window.centerY())
    {
      float shift = window.centerY() - graph.get(lastPoint).y;
      for (int i = 0; i < graph.size(); ++i)
      {
        graph.get(i).y += shift;
      }
    }
  }
}
