class SmartDotsGame
{
  // FIELDS
  private ArrayList<Level> levels;
  private int obstaclesWidth;
  // CONSTRUCTORS
  SmartDotsGame()
  {
    obstaclesWidth = 20;
    levels = new ArrayList<Level>();
    // 0
    Level zeroLevel = new Level(0, 160); // no obtacles
    // little help
    //zeroLevel.addCoin(width/2, height/2); // add coins so your dots know in which directions they should move
    levels.add(zeroLevel);
    
    // 1
    Level firstLevel = new Level(1, 250); // 1 obstacles: 
    firstLevel.addObstacle(width/4, height/2, width/2, obstaclesWidth, 0.5);// long horizontal bar in the middle
    levels.add(firstLevel);
    
    // 2
    Level secondLevel = new Level(2, 250); // 3 obstacles:
    secondLevel.addObstacle(width/4, height/3 + height/3, width/2, obstaclesWidth, 0.3);// long horizontal bar in the bottom  
    secondLevel.addObstacle(0, height/3,  width/3, obstaclesWidth, 0.7);// short horizontal bar in the top left
    secondLevel.addObstacle(2*width/3 ,height/3, width/3, obstaclesWidth, 0.7);// short horizontal bar in the top right
    levels.add(secondLevel);
    
    // 3
    Level thirdLevel = new Level(3, 370); // 2 obstacles 2(0) coins: 
    thirdLevel.addCoin(2*width/8, 5*height/8);
    thirdLevel.addCoin(7*width/9, height/5);
    thirdLevel.addObstacle(width/4, 3*height/4, 3*width/4, obstaclesWidth, 0.2);// long horizontal bar in the bottom 
    thirdLevel.addObstacle(0, height/4, 3*width/4, obstaclesWidth, 0.4);// long horizontal bar in the top 
    levels.add(thirdLevel);
    
    // 4
    Level fourthlevel = new Level(4, 480);// 4 obstacles 4 coins: 
    fourthlevel.addCoin(width/8, 5*height/8);
    fourthlevel.addCoin(3*width/8, height/8);
    fourthlevel.addCoin(3*width/8, 5*height/8);
    fourthlevel.addCoin(5*width/8, 3*height/8);
    fourthlevel.setGoal(7*width/8, 2*height/3); // new goal, right side bellow middle
    fourthlevel.addObstacle(width/4, 3*height/4, 3*width/4, obstaclesWidth, 0.3); // long horizontal bar in the bottom
    fourthlevel.addObstacle(width/4, 0, obstaclesWidth, height/2, 0.5); // long vertical bar in the left
    fourthlevel.addObstacle(width/2, height/4, obstaclesWidth, height/2, 0.6); // long vertical bar in the right
    fourthlevel.addObstacle(3*width/4, height/2, width/4, obstaclesWidth, 0.9); // short horizontal bar in the bottom
    levels.add(fourthlevel);
    
    // 5
    Level fifthlevel = new Level(5, 500);
    fifthlevel = new Level(3,500);// spiral obstacles:
    fifthlevel.addCoin(width/16, 15*height/16);
    fifthlevel.addCoin(width/16, height/16);
    fifthlevel.addCoin(15*width/16, height/16);
    fifthlevel.addCoin(15*width/16, 13*height/16);
    fifthlevel.addCoin(3*width/16, 13*height/16);
    fifthlevel.addCoin(3*width/16, 3*height/16);
    fifthlevel.addCoin(13*width/16, 3*height/16);
    fifthlevel.addCoin(13*width/16, 11*height/16);
    fifthlevel.addCoin(5*width/16, 11*height/16);
    fifthlevel.addCoin(5*width/16, 5*height/16);
    fifthlevel.addCoin(11*width/16, 5*height/16);
    fifthlevel.addCoin(11*width/16, 9*height/16);    
    fifthlevel.setGoal(width/2, height/2); // new goal, middle
    fifthlevel.addObstacle(width/8, 7*height/8, 7*width/8,obstaclesWidth, 0.2);
    fifthlevel.addObstacle(width/8, height/8, obstaclesWidth, 6*height/8, 0.25);
    fifthlevel.addObstacle(width/8, height/8, 6*width/8, obstaclesWidth, 0.3);
    fifthlevel.addObstacle(7*width/8, height/8, obstaclesWidth, 5*height/8, 0.35);
    fifthlevel.addObstacle(2*width/8, 6*height/8, 5*width/8+obstaclesWidth, obstaclesWidth, 0.4);
    fifthlevel.addObstacle(2*width/8, 2*height/8, obstaclesWidth, 4*height/8, 0.45);
    fifthlevel.addObstacle(2*width/8, 2*height/8, 4*width/8, obstaclesWidth, 0.5);
    fifthlevel.addObstacle(6*width/8, 2*height/8, obstaclesWidth, 3*height/8, 0.55);
    fifthlevel.addObstacle(3*width/8, 5*height/8, 3*width/8+obstaclesWidth, obstaclesWidth, 0.6);
    fifthlevel.addObstacle(3*width/8, 3*height/8, obstaclesWidth, 2*height/8, 0.65);
    fifthlevel.addObstacle(3*width/8, 3*height/8, 2*width/8, obstaclesWidth, 0.7);
    fifthlevel.addObstacle(5*width/8, 3*height/8, obstaclesWidth, height/8, 0.75);
    levels.add(fifthlevel);
    
  }
  Level getLevel(int index)
  {
    return levels.get(abs(index)%levels.size());
  }
  void addLevel(Level l)
  {
    levels.add(l);
  }
}
