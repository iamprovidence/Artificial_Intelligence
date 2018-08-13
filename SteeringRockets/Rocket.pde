class Rocket
{
  // CONST
  final private float maxSpeed = 3;
  final private float maxForce = 0.2;
  final private float mutationRate = 0.5;// chance for see distance and health to slightly change   
  
  // FIELDS
  private PVector position;
  private PVector acceleration;
  private PVector velocity;
  
  private Brain brain;
  private float health;
  private int radius;
  private float seeDistance;
  // CONSTRUCTORS
  Rocket(float x, float y)
  {
    position = new PVector(x, y);
    velocity = new PVector(0, 0);
    acceleration = new PVector(0, 0);
    
    brain = new Brain();
    health = 5;
    radius = 5;
    seeDistance = 25;
  }
  // METHODS
  void show()
  {
    float theta = this.velocity.heading() + PI / 2;
    // limit the positions
    this.position.x = constrain(this.position.x, 0, width);
    this.position.y = constrain(this.position.y, 0, height);
    
    pushMatrix();
    translate(this.position.x, this.position.y);
    rotate(theta);
    // light
    noStroke();
    ellipseMode(RADIUS);
    // from gray to yellow
    fill(lerpColor(color(200,200,150), color(250,255,90), health));
    ellipse(0, 0, seeDistance, seeDistance);
    
    // rocket
    stroke(255);
    // from red to green
    fill(lerpColor(color(255,0,0), color(0,255,0), health));
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
          this.health += collidedWith.HealthEffects();
          brain.setLiking(collidedWith, collidedWith.HealthEffects());
          objects.get(i).setRandomPosition();// spawn object far away
        }
      }
      
      // slowly loosing life
      health -= 0.001;
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
      if(this.position.dist(objects.getPosition(i)) <= seeDistance)
      {
        seeingObjects.add(allObjects.get(i));
      }
    }
    // find nothing
    if(seeingObjects.size() == 0)
    {
      // go somewhere else on distance you can see
      this.steerTo(new PVector(this.position.x + random(-seeDistance,seeDistance), 
                               this.position.y + random(-seeDistance,seeDistance)));
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
        if(random(-1, 2) < brain.getLikingByType(seeingObjects.get(i)))
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
      return;
    }
    else
    {
      // ... or go somewhere else on distance you can see
      this.steerTo(new PVector(this.position.x + random(-seeDistance,seeDistance), 
                               this.position.y + random(-seeDistance,seeDistance)));
      return;
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
    Rocket clone = new Rocket(position.x, position.y);
    clone.brain = this.brain.clone().mutate();
    return clone;
  }
  Rocket mutate()
  {
    if(random(1) < mutationRate) seeDistance += random(-2, 2);
    if(random(1) < mutationRate) health = random(-2, 2);
    return this;
  }
  // GETS
  public boolean isDead()
  {
    return health <= 0;
  }
  PVector getPosition()
  {
    return position;
  }
  float getHealth()
  {
    return health;
  }
  int getRadius()
  {
    return radius;
  }
}
