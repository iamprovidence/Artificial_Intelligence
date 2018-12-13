class RocketInfo
{
  // FIELDS
  float maxHealth;
  float health;
  float seeDistance;
  color rocketColor;
  color lightColor;
  HashMap<Class, Float> objectLiking;
  // CONSTRUCTORS
  RocketInfo(float health, float seeDistance, color rocketColor, color lightColor, HashMap<Class, Float> objectLiking)
  {
    this.maxHealth = health;
    this.health = health;
    this.seeDistance = seeDistance;
    this.rocketColor = rocketColor;
    this.lightColor = lightColor;
    this.objectLiking = objectLiking;
  }  
  RocketInfo(float health, float seeDistance, HashMap<Class, Float> objectLiking)
  {
    this(health, seeDistance, color(0,255,0), color(250,255,90), objectLiking);
  } 
  // METHODS
  void update()
  {    
      // slowly loosing life
      this.setHealth(-0.001);
      // from red to green(rocketColor)
      this.rocketColor = lerpColor(color(255,0,0), rocketColor, map(health, 0, maxHealth, 0, 3));
      // from gray to yellow(lightColor)
      this.lightColor = lerpColor(color(200,200,150), lightColor, map(health, 0, maxHealth, 0, 3));
  }
  void setLiking(HashMap<Class, Float> objectLiking)
  {
    this.objectLiking = objectLiking;
  }
  void setHealth(float health)
  {
    this.health += health;
    this.health = constrain(this.health, -maxHealth, maxHealth);
  } 
  void setMaxHealth(float health)
  {
    this.maxHealth += health;
    this.health = maxHealth;
  }
}
