# Artificial neural networks (ANN)
**Artificial neural networks (ANN)** or *connectionist systems* are computing systems vaguely inspired by the biological neural networks that constitute animal brains.

Such systems "learn" to perform tasks by considering examples, generally without being programmed with any task-specific rules. 
For example, in image recognition, they might learn to identify images that contain cats by analyzing example images that have been manually labeled as "cat" or "no cat" and using the results to identify cats in other images. They do this without any prior knowledge about cats, e.g., that they have fur, tails, whiskers and cat-like faces. Instead, they automatically generate identifying characteristics from the learning material that they process.

# Contents
* [Biology](#biology)
  - [Brain](#brain)
  - [Neuron](#neuron)
* [Components](#components)
  - [Learning rule](#learning rule)
  - [Connections](#connections)
  - [Layer](#layer)
  - [Neuron](#neuron)
    - [Sum up function](#sum-up-function)
    - [Activation function](#activation-function)
    - [Output](#output)
    - [Abilities](#abilities)
    - [Bias](#bias)
    - [Training](#training)
  - Algorithms
    - Propagation (Feed forward)
    - Backpropagation
* Remark
* Glossary

## Biology
As was mentioned before, neural networks is a human attempt to recreate brain. Despite the complexity of the brain, we will try to highlight only its main functions.

### Brain
The brain is much more difficult than any modern computer. 

It contains millions of *neuron*s that are interconnected. 

They *send* to the body and *receive* electrical signals from it.
<p align="center">
  <img src="/readme Imgs/neural network/brain.jpeg">
</p>

### Neuron
Neuron is a cell that processes and transmits information in the form of an electrical or chemical *signal*. 

Transmission of chemical signals occurs through *synapses* - contacts between neurons and other cells.

*Axon* is a nerve cell process that carries nerve impulses from the body of the cell to the innervating organs and other nerve cells.

If neuron receives enough electrical signal, it starts to transmit it forward.

Some connections between neurons are stronger than other.  Stronger connection transfer more signal.

<p align="center">
  <img src="/readme Imgs/neural network/neurons.png">
</p>

## Components
Let's simplify brain image. All we need is *neurons* (cirlces) and *connection* between them (lines).
<p align="center">
  <img src="/readme Imgs/neural network/Neural-Network.png">
</p>
Now we can describe each component one by one.

### Learning rule

The learning rule is a rule or an algorithm which modifies the parameters of the neural network, in order for a given input to the network to produce a favored output. 

This learning process typically amounts to modifying the weights, thresholds of the variables or adding new neurons within the network.

### Connections

There are **connections** between neurons.

The connection has **weight**. It is usualy a value in range [-1; 1].

Stronger connection transfer more signal.

### Layer

Neurons are placed on **layers**:

* The first level of neurons called **input layer**.
* The middle levels of neurons called **hidden layer**.
* The last level of neurons called **output layer**.

<p align="center">
  <img src="/readme Imgs/neural network/nn_layer.png">
</p>

The connections between neurons are traditionally spread only by one layer.

Each next hidden layer combines the features of the previous one.

### Neuron
An artificial neuron is a model of biological neurons. Artificial neurons are elementary units in an artificial neural network. 

The artificial neuron receives one or more inputs and sums them to produce an output.

<p align="center">
  <img src="/readme Imgs/neural network/neuron.png">
</p>

If neuron receives enough energy(or depending on time), it starts to transmit it forward.

The neuron consist of the following components:

* an output function, also known as sum up function
* an activation function


#### Sum up function
Take each input and multiply it by its weight: <img src="/readme Imgs/neural network/sum_up.svg"> 

```C#
private float SumUp(float[] inputs)
{
    float sum = 0; 
    for(int i = 0; i < inputs.length; ++i)
    {
        sum += weights[i] * inputs[i];
    }
    return sum;
}
```

#### Activation function

Вefines the threshold for the neuron activating.

It is usualy a value in range [-1; 1] or [0; 1].

**Examples:**

The most common. 

| Name  | Plot | Equation | Derivative |
| ------------- | ------------- | ------------- | ------------- |
| Identity | <img src="/readme Imgs/neural network/Activation Function/Identity/img.svg"> | <img src="/readme Imgs/neural network/Activation Function/Identity/func.svg"> | <img src="/readme Imgs/neural network/Activation Function/Identity/deriv.svg">  |
| Relu | <img src="/readme Imgs/neural network/Activation Function/Relu/img.svg"> | <img src="/readme Imgs/neural network/Activation Function/Relu/func.svg"> | <img src="/readme Imgs/neural network/Activation Function/Relu/deriv.svg">  |
| Sigmoid | <img src="/readme Imgs/neural network/Activation Function/Sigmoid/img.svg"> | <img src="/readme Imgs/neural network/Activation Function/Sigmoid/func.svg"> | <img src="/readme Imgs/neural network/Activation Function/Sigmoid/deriv.svg">  |
| Binary Step | <img src="/readme Imgs/neural network/Activation Function/Step/img.svg"> | <img src="/readme Imgs/neural network/Activation Function/Step/func.svg"> | <img src="/readme Imgs/neural network/Activation Function/Step/deriv.svg">  |
| Tanh | <img src="/readme Imgs/neural network/Activation Function/Tanh/img.svg"> | <img src="/readme Imgs/neural network/Activation Function/Tanh/func.svg"> | <img src="/readme Imgs/neural network/Activation Function/Tanh/deriv.svg">  |

Relu is the most used.

Coding example:

```C#
private int Step(float x)
{
   if (x > 0) return 1;
   else return -1;
}
```

#### Output

The the whole process(output) for a single neuron look like this :
<img src="/readme Imgs/neural network/neuron_output.svg"> 

```C#
public int Output(float[] inputs)
{
   return activationFunction(sumUp(inputs));
}
```

#### Abilities

It was prooved that a single neuron can only solve *linearly separable problems*. Basicaly, something that you can divide with one line.
<p align="center">
  <img height="100" width="125" src="/readme Imgs/neural network/linear_sep.svg">
  <img height="100" width="350" src="/readme Imgs/neural network/and_or.png">
</p>
But there are a lot of tasks that we cannot solve only with one line.
<p align="center">
  <img height="100" width="125" src="/readme Imgs/neural network/lns.svg">
  <img height="100" width="400" src="/readme Imgs/neural network/xor.png">
</p>
For this problems we need more than one neuron. That a reson why we combine neurons in neural networks.

#### Bias

Now when we know that we can teach neural network to solve linearly separable problems, let's look how good it will classify points as living on either one side of the line or the other.

The first input would be *X* value, the second — *Y* value. The result *0* or *1* depending on the category.

<p align="center">
  <img src="/readme Imgs/neural network/coordinate.gif">
</p>

This task is not hard but what about point (0, 0). No matter what the inputs weights are, the result of the *Sum Up* function will always be **0**. But this can’t be right — after all, the point (0,0) could certainly be above or below various lines in our two-dimensional world.

To avoid this dilemma, our neuron will require a third input, typically referred to as a **bias** input. The bias is a measure of how easy it is to get the perceptron to fire. For a perceptron with a really big bias, it's extremely easy for the perceptron to output a 1. But if the bias is very negative, then it's difficult for the perceptron to output a 1. 

A bias input traditionall has the value of 1 and is also weighted.

<p align="center">
  <img src="/readme Imgs/neural network/bias.png">
</p>

#### Training

Talking about point classification task. How neutron learn classification rule? Firtly it was randomly, the neuron has no better than a 50/50 chance of arriving at the right answer. Neural network not going to be able to guess anything correctly unless we teach it how to.

To train a neural network to answer correctly, we’re going to employ the method of supervised learning.

The network is provided with inputs for which there is a known answer. This way the network can find out if it has made a correct guess. If it’s incorrect, the network can learn from its mistake and adjust its weights

The neuron’s error can be defined as the difference between the desired answer and its guess.

**ERROR = DESIRED OUTPUT - GUESS OUTPUT**

It tell us how to adjusting the weights of a neural network to arrive at the right answer.

If the neuron guesses the correct answer, then the guess equals the desired output and the error is 0. 
If the correct answer is -1 and we’ve guessed +1, then the error is -2. 
If the correct answer is +1 and we’ve guessed -1, then the error is +2.

| Desired |	Guess |	Error |
| ------- | ----- | ----- |
|   - 1   |  - 1  |   0   |
|   - 1   |  + 1  |  - 2  |
|   + 1   |  - 1  |  + 2  |
|   + 1   |  + 1  |   0   |


For any given weight, what we are looking to calculate is the change in weight, often called Δweight.

**NEW WEIGHT = WEIGHT + ΔWEIGHT**

Δweight is calculated as the error multiplied by the input.

**ΔWEIGHT = ERROR * INPUT**

Therefore:

**NEW WEIGHT = WEIGHT + ERROR * INPUT**

But if we adjusted our weight too much, we would need to adhust it again. If too low, it would take a lot of time to get to the right result. To avoid this probleb we enter a variable which control learning:

**NEW WEIGHT = WEIGHT + ERROR * INPUT * LEARNING CONSTANT**

Coding example:

```C#
private const float leariningRate = 0.01;

public void train(float[] inputs, int target)
{
    int error = target - this.output(inputs);
    
    for(int i = 0; i < weights.length; ++i)
    {
      weights[i] += error * inputs[i] * leariningRate;
    }
}
```

### Algorithms

All algorithm that we used for a single neuron a still valid or a neural network. But now we operate not values but matrices. 

Now we want to think about bias as additional neuron in each layer except the last one.

#### Propagation (Feed forward)

As was mentioned previous, single neuron receives inputs and sends outputs with sum up and actibation functions help.

Propagation, also known as feed forward algorithm doing the same but not with one neuron but with whole layer of neurons.

We have are vector of inputs in first layer, bias as last neuron, all connection weights to next layer and we want to find the values of neurons in next layer after activation in this layer and repeat this until we get outputs values.

<p align="center">
  <img src="/readme Imgs/neural network/propagation/img.png">
</p>

All we need is to take each input, multiply it by its weight and apply activation function. But we don't have one input and array of weights, we have many inputs so let's think about them as a vector and matrix of weights.

<p align="center">
  <img src="/readme Imgs/neural network/propagation/form.png">
</p>

Since, bias is constant value and only bias's weights metter we can think of it as a separate component.

After applying activation function formula looks:
<p align="center">
  <img src="/readme Imgs/neural network/propagation/mainF.png">
</p>

Coding example:
```C#
private double[] output(double[] input)
{
    Vector input = new Vector(input);

    for (int i = 0; i < weights.Length; ++i)
    {
        input = activationFunction(weights[i] * input + biases[i]);
    }

    return inputForNextLayer.ToArray();
}
```


#### Backpropagation



## Glossary

* **Terms**
  - layer — the cols where neurons are placed
  - input layer — the first layer of neurons
  - hidden layer — the middle layers of neurons
  - output layer — the last layer of neurons
  - connection — the connection between the neurons through which energy is transmitted
  - connection weight — determines how strong is the connection between neurons 
  - linearly separable problem — problem that you can solve by divided it with one line.
