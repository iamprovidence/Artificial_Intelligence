class Face
{
  // CONST
  final private float mutationRate = 0.1;// 10%
  final private float w = 200;
  final private float h = 200;
  final private float y = 10;
  // FIELDS
  private float x;
  
  private int faceType;
  private color faceColor;
  private float faceSize;
  
  private int eyesType;
  private color eyesColor;
  private float eyesWidth;
  private float eyesLength; 
  
  private int mouthType;
  private color mouthColor; 
  private float mouthWidth;
  private float mouthLength;
  
  private int fitness;
  // CONSTRUCTORS
  private Face(){ }
  Face(float x)
  {
    this.x = x;
    
    faceType = floor(random(2));
    faceColor = color(random(255), random(255), random(255));
    faceSize = random(w/4, 2*w/3);
    
    eyesType = floor(random(2));
    eyesColor = color(random(255), random(255), random(255));
    eyesWidth = random(w/7, 2*w/5);
    eyesLength = random(w/7, 2*w/5);
    
    mouthType = floor(random(2));
    mouthColor = color(random(255), random(255), random(255));
    mouthWidth = random(w/8, w/3);    
    mouthLength = random(w/8, w/3);
  }
  // METHODS
  void show()
  {
    rectMode(CORNER);
    // area
    fill(255);
    rect(x, y, w, h);
    fill(0);    
    text(fitness, x + (w)/2, y + h - 10);
    // face
    ellipseMode(CENTER);
    rectMode(CENTER);
    showFace();
    showEyes();
    showMouth();
  }
  void update()
  {
    show();
    if(mouseHover())
    {
      ++fitness;
    }
  }
  private void showFace()
  {
    fill(faceColor);
    switch(faceType)
    {
      case 0: ellipse(x + (w)/2, y+(h)/2, faceSize, faceSize); break;
      case 1: rect(x+(w)/2, y+(h)/2, faceSize, faceSize); break;
    }
  }
  private void showEyes()
  {
    fill(eyesColor);
    switch(eyesType)
    {
      case 0: 
        ellipse(x+(w)/4, y+(h)/3, eyesWidth, eyesLength); 
        ellipse(x+3*(w)/4, y+(h)/3, eyesWidth, eyesLength);
      break;
      case 1: 
        rect(x+(w)/4, y+(h)/3, eyesWidth, eyesLength);
        rect(x+3*(w)/4, y+(h)/3, eyesWidth, eyesLength);
      break;
    }
  }
  private void showMouth()
  {
    fill(mouthColor);
    switch(mouthType)
    {
      case 0: ellipse(x+(w)/2, y+2*(h)/3, mouthWidth, mouthLength); break;
      case 1: rect(x+(w)/2, y+2*(h)/3, mouthWidth, mouthLength); break;
    }
  }
  // randomly choosing feater from both parent
  Face crossover(Face secondParent)
  {
    Face child = new Face();
    
    child.faceType = (random(1) < 0.5) ? this.faceType : secondParent.faceType;
    child.faceColor = lerpColor(this.faceColor, secondParent.faceColor, random(1));
    child.faceSize = (random(1) < 0.5) ? this.faceSize : secondParent.faceSize;
    
    child.eyesType = (random(1) < 0.5) ? this.eyesType : secondParent.eyesType;
    child.eyesColor = lerpColor(this.eyesColor, secondParent.eyesColor, random(1));
    child.eyesWidth = (random(1) < 0.5) ? this.eyesWidth : secondParent.eyesWidth;
    child.eyesLength = (random(1) < 0.5) ? this.eyesLength : secondParent.eyesLength;
    
    child.mouthType = (random(1) < 0.5) ? this.mouthType : secondParent.mouthType;
    child.mouthColor = lerpColor(this.mouthColor, secondParent.mouthColor, random(1));
    child.mouthWidth = (random(1) < 0.5) ? this.mouthWidth : secondParent.mouthWidth;
    child.mouthLength = (random(1) < 0.5) ? this.mouthLength : secondParent.mouthLength;
  
    return child;
  }
  Face clone()
  {
    Face clone = new Face();
    
    clone.faceType = this.faceType;
    clone.faceColor = this.faceColor;
    clone.faceSize = this.faceSize;
    
    clone.eyesType = this.eyesType;
    clone.eyesColor = this.eyesColor;
    clone.eyesWidth = this.eyesWidth;
    clone.eyesLength = this.eyesLength;
    
    clone.mouthType = this.mouthType;
    clone.mouthColor = this.mouthColor;
    clone.mouthWidth = this.mouthWidth;
    clone.mouthLength = this.mouthLength;
     
    return clone;
  }
  Face mutate()
  {
    if(random(1) < mutationRate) this.faceType = floor(random(2));
    if(random(1) < mutationRate) this.faceColor = color(random(255), random(255), random(255));;
    if(random(1) < mutationRate) this.faceSize += random(-10, 10);
    
    if(random(1) < mutationRate) this.eyesType = floor(random(2));
    if(random(1) < mutationRate) this.eyesColor = color(random(255), random(255), random(255));
    if(random(1) < mutationRate) this.eyesWidth += random(-10, 10);
    if(random(1) < mutationRate) this.eyesLength += random(-10, 10);
    
    if(random(1) < mutationRate) this.mouthType = floor(random(2));
    if(random(1) < mutationRate) this.mouthColor = color(random(255), random(255), random(255));
    if(random(1) < mutationRate) this.mouthWidth += random(-10, 10);
    if(random(1) < mutationRate) this.mouthLength += random(-10, 10);
    
    return this;
  }
  boolean mouseHover() 
  {
     return (mouseX >= x &&   // right of the left edge AND
        mouseX <= x +w &&     // left of the right edge AND
        mouseY >= y &&        // below the top AND
        mouseY <= y + h);     // above the bottom
  }
  int getScore()
  {
    return fitness;
  }
  float getX()
  {
    return x;
  }
  void setX(float x)
  {
    this.x = x;
  }
}
