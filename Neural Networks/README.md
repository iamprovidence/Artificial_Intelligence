# Artificial neural networks (ANN)
**Artificial neural networks (ANN)** or *connectionist systems* are computing systems vaguely inspired by the biological neural networks that constitute animal brains.

Such systems "learn" to perform tasks by considering examples, generally without being programmed with any task-specific rules. 
For example, in image recognition, they might learn to identify images that contain cats by analyzing example images that have been manually labeled as "cat" or "no cat" and using the results to identify cats in other images. They do this without any prior knowledge about cats, e.g., that they have fur, tails, whiskers and cat-like faces. Instead, they automatically generate identifying characteristics from the learning material that they process.

# Contents
* [Biology](#biology)
  - [Brain](#brain)
  - [Neuron](#neuron)
* Components
  - Neuron
    - Activation function
    - Sum up function
  - Layer
  - Connections
  - Bias
  - Algorithms
    - Feed forward
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
  <img src="https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fwww.2Efemmeactuelle.2Efr.2Fvar.2Ffemmeactuelle.2Fstorage.2Fimages.2Fsante.2Fsante-pratique.2Fsla-maladie-de-charcot-22714.2F13558466-1-fre-FR.2Fla-sla-ou-maladie-de-charcot-une-affection-degenerative.2Ejpg/748x372/quality/80/crop-from/center/la-sla-ou-maladie-de-charcot-une-affection-degenerative.jpeg">
</p>

### Neuron
Neuron is a cell that processes and transmits information in the form of an electrical or chemical *signal*. 

Transmission of chemical signals occurs through *synapses* - contacts between neurons and other cells.

*Axon* is a nerve cell process that carries nerve impulses from the body of the cell to the innervating organs and other nerve cells.

If neuron receives enough electrical signal, it starts to transmit it forward.

Some connections between neurons are stronger than other.  Stronger connection transfer more signal.

<p align="center">
  <img src="http://bcs.whfreeman.com/webpub/Ektron/Hillis%20Principles%20of%20Life2e/Animated%20Tutorials/pol2e_at_3404_neurons_and_synapses/img/neurons.png">
</p>

## Components
Let's simplify brain image. All we need is neurons (cirlces) and connection between them (lines).
<p align="center">
  <img src="https://files.phpclasses.org/files/blog/file/Neural-Network.png">
</p>
Now we can describe each component one by one.
### Neuron
