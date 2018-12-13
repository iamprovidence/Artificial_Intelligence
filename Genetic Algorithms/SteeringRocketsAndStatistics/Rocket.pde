class Rocket
{
  // CONST
  final private float maxSpeed = 3;
  final private float maxForce = 0.2;
  final private float mutationRate = 0.5;// chance for see distance and health to slightly change 
  final private int radius = 5;
  
  // FIELDS
  private PVector position;
  private PVector acceleration;
  private PVector velocity;
  
  private Brain brain;
  private RocketInfo info;
  private Window areaToMove;
  // CONSTRUCTORS
  Rocket(float x, float y, Window window)
  {
    position = new PVector(x, y);
    velocity = new PVector(0, 0);
    acceleration = new PVector(0, 0);
    
    brain = new Brain();
    // health, seeDistance, rocketColor, lightColor, objectLiking
    info = new RocketInfo(5, 25, color(0,255,0), color(250,255,90), brain.getObjectLiking());
    
    this.areaToMove = window;
  }
  // METHODS
  void show()
  {
    float theta = this.velocity.heading() + PI / 2;
    // limit the positions
    this.position.x = constrain(this.position.x, areaToMove.minX(), areaToMove.maxX());
    this.position.y = constrain(this.position.y, areaToMove.minY(), areaToMove.maxY());
    
    pushMatrix();
    translate(this.position.x, this.position.y);
    rotate(theta);
    // light
    noStroke();
    ellipseMode(RADIUS);
    fill(info.lightColor);
    ellipse(0, 0, info.seeDistance, info.seeDistance);
    
    // rocket
    stroke(255);
    strokeWeight(1);
    fill(info.rocketColor);
    beginShape();
      vertex(0, -radius * 2);
      vertex(-radius, radius * 2);
      vertex(radius, radius * 2);
    endShape(CLOSE);
    popMatrix();
  }
  void move()
  {
    velocity.add(acceleration);
    velocity.limit(maxSpeed); // limit speed
    position.add(velocity);
    acceleration.mult(0); // reset
  }
  void update()
  {
    show();
    if(!isDead())
    {
      move();
      seeking();
      // check for collision
      Objects objects = brain.getObjectsToCollect();
      for(int i = 0; i < objects.size(); ++i)
      {
        // if rocket have collised with object
        if(objects.get(i).checkCollision(this))
        {
          // determine how good this object is
          Object collidedWith = objects.get(i);
          this.info.setHealth(collidedWith.HealthEffects());
          brain.setLiking(collidedWith.getClass(), collidedWith.HealthEffects());
          objects.addToCollected(collidedWith.getClass(), 1);
          objects.get(i).setRandomPosition();// spawn object far away
        }
      }
      // slowly losing life, lerp color
      info.update();
    }
  }  
  void applyForce(PVector force)
  {
    acceleration.add(force);
  }
  void infoAboutObject(Objects objects)
  {
    brain.infoAboutObject(objects);
  }
  void goFor(Object o)
  {
    brain.goFor(o);
  }
  // SEEK FOR SMT, THAT RESTORE LIFE
  void seeking()
  {
    /*
    1. Get all object that you see
      if there no one move to random directions
    2. Look for closest and likable
      if there no likable move to random directions
    */
    // 1
    ArrayList<Object> seeingObjects = new ArrayList<Object>(10);
    Objects allObjects = brain.getObjectsToCollect();
    for(int i = 0; i < allObjects.size(); ++i)
    {       
      if(this.position.dist(objects.getPosition(i)) <= info.seeDistance)
      {
        seeingObjects.add(allObjects.get(i));
      }
    }
    // find nothing
    if(seeingObjects.size() == 0)
    {
      // go somewhere else on distance you can see
      this.steerTo(new PVector(this.position.x + random(-info.seeDistance,info.seeDistance), 
                               this.position.y + random(-info.seeDistance,info.seeDistance)));
      return;
    }
    // 2
    // look random amount (1-5) on object you would like
    for(int c = 0; c < random(1, 5); ++c)
    {
      for(int i = 0; i < seeingObjects.size(); ++i)
      {
        // look at object and decide do you want it
        // object you like has higher chance to be picked
        
        // if you like explosive you will lose life
        // and get experiance that explosive is bad
        // while resource is yummy
        if(random(-1, 2) < brain.getLikingByType(seeingObjects.get(i).getClass()))
        {
          this.steerTo(seeingObjects.get(i).getPosition());
          return;
        }
      }
    }
    // if there no likable ...
    if(random(1) > 0.5) // 50 %
    {
      // ...  just pick any and get an experiance
      this.steerTo(seeingObjects.get(floor(random(seeingObjects.size()))).getPosition());
    }
    else
    {
      // ... or go somewhere else on distance you can see
      this.steerTo(new PVector(this.position.x + random(-info.seeDistance,info.seeDistance), 
                               this.position.y + random(-info.seeDistance,info.seeDistance)));
    }
  }
  // STEERING = DESIRED - VELOCITY
  void steerTo(PVector target)
  {
    PVector desired = PVector.sub(target, this.position);
    
    // scale to maximum speed
    desired.setMag(this.maxSpeed);
    
    PVector steer = PVector.sub(desired, this.velocity);
    steer.limit(maxForce);
    
    this.applyForce(steer);
  }
  void seek(Objects objects)
  {
    float minDistance = width * height;
    int closestIndex = -1;
    
    for(int i = 0; i < objects.size(); ++i)
    {
       float distance = this.position.dist(objects.getPosition(i));
       if(distance < minDistance)
       {
         minDistance = distance;
         closestIndex = i;
       }
    }
    
    this.steerTo(objects.getPosition(closestIndex));
  }
  Rocket clone()
  {
    Rocket clone = new Rocket(position.x, position.y, areaToMove);
    clone.brain = this.brain.clone().mutate();
    // health, seeDistance, rocketColor, lightColor, objectLiking
    clone.info = new RocketInfo(this.info.health, this.info.seeDistance, clone.brain.getObjectLiking());
    return clone;
  }
  Rocket mutate()
  {
    if(random(1) < mutationRate) info.seeDistance += random(-2, 2);
    if(random(1) < mutationRate) info.setMaxHealth(random(-2, 2));
    return this;
  }
  // GETS
  public boolean isDead()
  {
    return info.health <= 0;
  }
  PVector getPosition()
  {
    return position;
  }
  float getHealth()
  {
    return info.health;
  }
  int getRadius()
  {
    return radius;
  }
  RocketInfo getInfo()
  {
    return info;
  }
}
