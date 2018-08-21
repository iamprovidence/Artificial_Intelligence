# Artificial neural networks (ANN)
**Artificial neural networks (ANN)** or *connectionist systems* are computing systems vaguely inspired by the biological neural networks that constitute animal brains.

Such systems "learn" to perform tasks by considering examples, generally without being programmed with any task-specific rules. 
For example, in image recognition, they might learn to identify images that contain cats by analyzing example images that have been manually labeled as "cat" or "no cat" and using the results to identify cats in other images. They do this without any prior knowledge about cats, e.g., that they have fur, tails, whiskers and cat-like faces. Instead, they automatically generate identifying characteristics from the learning material that they process.

# Contents
* [Biology](#biology)
  - [Brain](#brain)
  - [Neuron](#neuron)
* [Components](#components)
  - [Connections](#connections)
  - [Layer](#layer)
  - Neuron
    - Sum up function
    - Activation function
    - Output
    - [Abilities](#abilities)
  - Bias
  - Algorithms
    - Propagation (Feed forward)
    - Backpropagation
  - Learning rule
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

## Glossary

* **Terms**
  - layer — the cols where neurons are placed
  - input layer — the first layer of neurons
  - hidden layer — the middle layers of neurons
  - output layer — the last layer of neurons
  - connection — the connection between the neurons through which energy is transmitted
  - connection weight — determines how strong is the connection between neurons 
  - linearly separable problem — problem that you can solve by divided it with one line.
