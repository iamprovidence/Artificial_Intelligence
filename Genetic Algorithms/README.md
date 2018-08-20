# Genetic Algorithm

Genetic algorithms are commonly used to generate high-quality solutions to optimization and search problems by relying on bio-inspired operators such as *mutation*, *crossover* and *selection*.

## Steps

<p align="center">
  <img src="https://www.researchgate.net/profile/John_Geraghty2/publication/236179246/figure/fig1/AS:299498850013187@1448417498772/Genetic-algorithm-procedure-for-TSP.png">
</p>

1. Initialization
2. Evaluation
3. Selection 
4. Crossover
5. Mutation
6. Repeat until done

### Initialization
The population size depends on the nature of the problem, but typically contains several hundreds or thousands of possible solutions. Often, the initial population is generated **randomly**, allowing the entire range of possible solutions (the search space). Occasionally, the solutions may be "seeded" in areas where optimal solutions are likely to be found.

### Evaluation
For evaluating we often use a **fitness function**. The fitness function is a particular type of objective function that is used to summarise, as a single figure of merit, how close a given design solution is to achieving the set aims. 

The function should not be linear, but rather **exponential**. Then even small improvements will have a greater impact on adaptability.

The fitness function must not only correlate closely with the designer's goal, it must also be computed quickly. **Speed of execution** is very important, as a typical genetic algorithm must be iterated many times in order to produce a usable result for a non-trivial problem.

**Examples** of fitness function:
* how close computer was to the target
  - if aim the target, how many step it takes
* how much time user spend on category that computer has proposed
* how much time computer survives
* how much points computer get
* if computer get certain point
* **no fitness function at all**, the longer computer survives the better chance it has to reproduce itself
* etc

### Selection

During each successive generation, a portion of the existing population is selected to breed a new generation.

There are a lot of ways to select representer but the main idea is **"survive the strongest"**.

**Examples** of selection function:
* *elitist selection* — the population is sorted by descending fitness values. Tnen first **N** representers survive
* *tournament selection* — select **N** times, **k** (usually = 2) random representer and compare their fitness value. The one with better adaptability survives 
* *roulette-wheel selection* — each representer has a chance to be selected
  - the fitness function is evaluated for each individual, providing fitness values, which are then normalized. **Normalization** means dividing the fitness value of each individual by the sum of all fitness values, so that the sum of all resulting fitness values equals **1**. A random number **R** between **0 and 1** is chosen. The selected individual is the last one whose accumulated normalized value is greater than or equal to R
  - convert fitness value to integer, then create additional arrays which contain only pointer to individual. The pointer amount, for each representer, is equal to fitness value. A random number **R** between **0 and Pointer Array's Length** is chosen. The random value determine an index from pointer array, select the representer by pointer, so the selected indivuidual with higher fitness has higher chance to be choosen.
  - pick a random number **R1** between **0 and Population Array's Length**. The fitness function is evaluated for each individual, providing fitness values, which are then normalized in range of **0 and 1**. Pick a random number **R2** between **0 and 1**. If **R2 < Representer's fitness** select representer, else try again.
* combine previous selection algorithms, divide selection on steps
* etc

### Crossover

### Mutation

### Repeating
