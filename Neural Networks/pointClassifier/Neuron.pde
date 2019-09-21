class Neuron
{
  // CONSTS
  final private float leariningRate = 0.25;
  // FIELDS
  private float[] weights;
  // CONSTRUCTORS
  Neuron()
  {
    weights = new float[2];
    for(int i = 0; i < weights.length; ++i)
    {
      weights[i] = random(-1, 1);
    }
  }
  
  // METHODS
  void show(float x, float y, float w, float h)
  {
    // input 1
    strokeWeight(map(constrain(weights[0], -1, 1), -1, 1, 1, 5));
    stroke(lerpColor(color(255, 0 ,0), color(0, 255, 0), weights[0]));
    line(x + w/5, y+h/3, x+w/2, y+h/2);
    
    // input 2
    strokeWeight(map(constrain(weights[1], -1, 1), -1, 1, 1, 5));
    stroke(lerpColor(color(255, 0 ,0), color(0, 255, 0), weights[1]));
    line(x + w/5, y+2*h/3, x+w/2, y+h/2);
    
    // output
    stroke(0);
    strokeWeight(5);
    line(x+w/2, y+h/2, 4*w/5, y+h/2);
    
    // neuron
    strokeWeight(3);
    fill(255);
    ellipse(x+w/2, y+h/2, w/3, w/3);
  }
  int guess(float[] inputs)
  {
    return activationFunction(sumUp(inputs));
  }
  void train(float[] inputs, int target)
  {
    int error = target - guess(inputs);
    
    for(int i = 0; i < weights.length; ++i)
    {
      weights[i] += error * inputs[i] * leariningRate;
    }
  }
  private float sumUp(float[] inputs)
  {
    float sum = 0; 
    for(int i = 0; i < inputs.length; ++i)
    {
      sum += weights[i] * inputs[i];
    }
    return sum;
  }
  private int activationFunction(float x)
  {
    if (x > 0) return 1;
    else return -1;
  }
  private float guessY(float x)
  {
    float w1 = weights[0];
    float w2 = weights[1];
    
    // w1*x + w2*y = 0
    // w2*y = -w1*x
    // y = -w1*x/w2
    return - w1*x/w2;
  }
}
