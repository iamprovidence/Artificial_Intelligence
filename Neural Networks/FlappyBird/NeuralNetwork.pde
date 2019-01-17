class NeuralNetwork 
{
  // FIELDS
  private float learningRate;

  private int inputAmount;
  private int outputAmount;
  private int[] hiddenLayerAmount; // array consist of amount of neuron in each layer
  private int[] neuronPerLayer;

  private Matrix[] weights;
  private Matrix[] biases;
  // CONSTRUCTORS
  NeuralNetwork(int inputAmount, int[] hiddenAmount, int outputAmount)
  {
    this(inputAmount, hiddenAmount, outputAmount, 0.1);
  }
  NeuralNetwork(int inputAmount, int[] hiddenAmount, int outputAmount, float learningRate)
  {
    
    this.inputAmount = inputAmount;
    this.hiddenLayerAmount = hiddenAmount;
    this.outputAmount = outputAmount;
    this.learningRate = learningRate;
    this.biases = new Matrix[hiddenAmount.length + 1];// all hiden and INPUT have bias neuron
    // create additional array for easier way to fill matrix and track of algorithms
    // 2 stands for input and output layer
    this.neuronPerLayer = new int[2 + hiddenAmount.length];// amount of neuron in each layer
    neuronPerLayer[0] = inputAmount;
    neuronPerLayer[neuronPerLayer.length - 1] = outputAmount;
    // copy all hidden
    for (int i = 1; i < neuronPerLayer.length - 1; ++i)
    {
        neuronPerLayer[i] = hiddenAmount[i - 1];
        // biases
        biases[i - 1] = new Matrix(hiddenAmount[i - 1], 1).fill(1);
    }
    biases[biases.length - 1] = new Matrix(outputAmount, 1).fill(1);

    this.weights = new Matrix[neuronPerLayer.length - 1];
    for (int i = 0; i < weights.length; ++i)
    {
        // so we have fully connected neural network
        // ROWS = amount of neurons in next layer
        // COLS = amount of neurons in this layer 
        // firstly weight of connections are random
        weights[i] = new Matrix(neuronPerLayer[i + 1], neuronPerLayer[i]).randomize(-10, 10);
    }
  }
  NeuralNetwork(NeuralNetwork neuralNetwork)
  {
    this.learningRate = neuralNetwork.learningRate;
    
    this.inputAmount = neuralNetwork.inputAmount;
    this.outputAmount = neuralNetwork.outputAmount;
    
    this.hiddenLayerAmount = neuralNetwork.hiddenLayerAmount.clone();
    this.neuronPerLayer = neuralNetwork.neuronPerLayer.clone();
    
    this.biases = new Matrix[neuralNetwork.biases.length];
    for (int i = 0; i < this.biases.length; ++i)
    {
      biases[i] = neuralNetwork.biases[i].copy();
    }

    this.weights = new Matrix[neuralNetwork.weights.length];
    for (int i = 0; i < weights.length; ++i)
    {
        this.weights[i] = neuralNetwork.weights[i].copy();
    }
  }
  void setLearningRate(float learningRate) 
  {
    this.learningRate = learningRate;
  }
  void randomize()
  {
    randomize(0, Integer.MAX_VALUE);
  }
  void randomize(int min, int max)
  {
    for (int i = 0; i < biases.length; ++i)
    {
        biases[i].fill(1);
    }
    
    for (int i = 0; i < weights.length; ++i)
    {
        weights[i].randomize(min, max);
    }
  }
  NeuralNetwork copy() 
  {
    return new NeuralNetwork(this);
  }
  NeuralNetwork mutate(float min, float max, float chance)
  {
    for (int i = 0; i < this.biases.length; ++i)
    {      
      biases[i].mutate(min, max, chance);
    }

    for (int i = 0; i < weights.length; ++i)
    {
      weights[i].mutate(min, max, chance);
    }
    return this;
  }
  // METHODS
  public float[] guess(float[] input)
  {
    if (input.length != inputAmount) throw new IllegalArgumentException("Wrong amount of inputs");

    // return last result
    Matrix[] res = feedForward(input);        
    return res[res.length - 1].toArray();
  }
  private Matrix[] feedForward(float[] input)
  {
    Matrix[] inputForNextLayer = new Matrix[neuronPerLayer.length];
    inputForNextLayer[0] = new Matrix(input);

    for (int k = 0; k < weights.length; ++k)
    {
        inputForNextLayer[k + 1] = (weights[k].multiplying(inputForNextLayer[k])).add(biases[k]);
        
        // applying activation function
        for(int i = 0; i < inputForNextLayer[k + 1].rows(); ++i)
        {
          for (int j = 0; j < inputForNextLayer[k + 1].cols(); ++j)
          {
            inputForNextLayer[k + 1].set(i, j, Relu(inputForNextLayer[k + 1].get(i, j)));
          }
        }
    }

    return inputForNextLayer;
  }
}
