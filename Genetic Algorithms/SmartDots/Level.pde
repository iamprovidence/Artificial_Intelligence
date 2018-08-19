class Level
{
  // FIELDS
  private PVector goal;
  private int goalSize;
  private ArrayList<PVector> coins;
  private int coinsCollected;
  private ArrayList<Rect> obstacles;
  
  private int number;
  private int minStepAmountToPass;
  private boolean didWin;
  
  private float textSize;
  private float textColor;
  private int textSpeed;
  
  // CONSTRUCTORS
  Level(int levelNumber, int stepNeeded)
  {
    coins = new ArrayList<PVector>();
    coinsCollected = 0;
    
    textSize = 50;
    textColor = 0;
    textSpeed = 3;
    didWin = false;
    
    minStepAmountToPass = stepNeeded;
    goal = new PVector(width/2, 10);
    goalSize = 10;
    number = levelNumber;
    obstacles = new ArrayList<Rect>();
  }
  void show()
  { 
    // GOAL
    fill(255, 0, 0); // red
    stroke(0);
    ellipse(goal.x, goal.y, goalSize, goalSize);
    showCoins();
    
    // OBSTACLES
    for (Rect obstacle : obstacles)
    {
       obstacle.draw(); 
    }
    
    // TEXT
    textAlign(LEFT, BOTTOM);
    textSize(10);
    fill(12);
    text("Level № " + number, 10, 15); // right top corner
    if(allCoinsCollected())
    {
      text("Need reach goal with " + minStepAmountToPass + " steps", 10, 30);
    }
    else
    {
      text("Need to collect " + (coins.size()-coinsCollected) + " coins", 10, 30);
    }
    // fancy fade out in the middle
    if(textColor < 230)
    {
      textAlign(CENTER, CENTER);
      textSize(textSize);
      fill(textColor);
      text(number, width / 2, height / 2);
      textSize += textSpeed * 0.1;
      textColor += textSpeed;
    }
    if(didWin)
    {
      textAlign(CENTER, CENTER);
      textSize(25);
      fill(100);
      text("YOU WIN", width / 2, height / 2);
    }
  }
  private void showCoins()
  {
    int k = 1;
    for(int i = coinsCollected; i < coins.size(); ++i)
    {
      // coin
      fill(255, 255, 0); // yellow
      stroke(255, 100, 0); // orange
      ellipse(coins.get(i).x, coins.get(i).y, goalSize, goalSize);
      // text in it
      fill(255, 100, 0);
      textAlign(CENTER, CENTER);
      textSize(goalSize - 2);
      text(k, coins.get(i).x, coins.get(i).y);
      ++k;
    }
  }
  
  boolean isLevelPased(int stepDone)
  {
    return didWin = minStepAmountToPass >= stepDone && allCoinsCollected();
  }
  // SET GET ADD
  PVector getGoal()
  {
    if(allCoinsCollected())
    {
      return goal;
    }
    return coins.get(coinsCollected);
  }
  int getGoalRadius()
  {
    return goalSize / 2;
  }
  Rect[] getObstacles()
  {
    return obstacles.toArray(new Rect[0]);
  }
  void setGoal(float x, float y)
  {
    goal = new PVector(x, y);
  }
  boolean allCoinsCollected()
  {
    return coinsCollected == coins.size();
  }
  void collectCoin()
  {
    ++coinsCollected;
  }
  void addObstacle(float x, float y, float w, float h,float v)
  {
    obstacles.add(new Rect(x, y, w, h, v));
  }
  void addCoin(float x, float y)
  {
    coins.add(new PVector(x, y));
  }
}
