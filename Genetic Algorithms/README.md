# Genetic Algorithm

Genetic algorithms are commonly used to generate high-quality solutions to optimization and search problems by relying on bio-inspired operators such as *mutation*, *crossover* and *selection*.
# Contents
* [Steps](#steps)
  - [Initialization](#initialization)
  - [Evaluation](#evaluation)
  - [Selection](#selection)
  - [Crossover](#crossover)
  - [Mutation](#mutation)
  - [Termination](#termination)
* [Remark](#remark)
* [Glossary](#glossary)

## Steps
Basically, all process can be described as selecting better solution from better solution.
<p align="center">
  <img src="https://www.researchgate.net/profile/John_Geraghty2/publication/236179246/figure/fig1/AS:299498850013187@1448417498772/Genetic-algorithm-procedure-for-TSP.png">
</p>

1. Initialization
2. Evaluation
3. Selection 
4. Crossover
5. Mutation
6. Termination

### Initialization
The population size depends on the nature of the problem, but typically contains several hundreds or thousands of possible solutions. Often, the initial population is generated **randomly**, allowing the entire range of possible solutions (the search space). Occasionally, the solutions may be "seeded" in areas where optimal solutions are likely to be found.

### Evaluation
For evaluating we often use a **fitness function**. The fitness function is a particular type of objective function that is used to summarise, as a single figure of merit, how close a given design solution is to achieving the set aims. 

The function should not be linear, but rather **exponential**. Then even small improvements will have a greater impact on adaptability.

The fitness function must not only correlate closely with the designer's goal, it must also be computed quickly. **Speed of execution** is very important, as a typical genetic algorithm must be iterated many times in order to produce a usable result for a non-trivial problem.

**Examples** of fitness algorithms:
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

**Examples** of selection algorithms:
* *elitist selection* — the population is sorted by descending fitness values. Tnen first **N** representers survive
* *tournament selection* — select **N** times, **k** (usually = 2) random representer and compare their fitness value. The one with better adaptability survives 
* *roulette-wheel selection* — each representer has a chance to be selected
  - the fitness function is evaluated for each individual, providing fitness values, which are then normalized. **Normalization** means dividing the fitness value of each individual by the sum of all fitness values, so that the sum of all resulting fitness values equals **1**. A random number **R** between **0 and 1** is chosen. The selected individual is the last one whose accumulated normalized value is greater than or equal to R
  - convert fitness value to integer, then create additional arrays which contain only pointer to individual. The pointer amount, for each representer, is equal to fitness value. A random number **R** between **0 and Pointer Array's Length** is chosen. The random value determine an index from pointer array, select the representer by pointer, so the selected indivuidual with higher fitness has higher chance to be choosen.
  - pick a random number **R1** between **0 and Population Array's Length**. The fitness function is evaluated for each individual, providing fitness values, which are then normalized in range of **0 and 1**. Pick a random number **R2** between **0 and 1**. If **R2 < Representer's fitness** select representer, else try again.
* combine previous selection algorithms, divide selection on steps
* etc

### Crossover

For each new solution to be produced, a pair of "parent" solutions is selected for breeding from the pool selected previously. By producing a "child" solution using the above methods of crossover, a new solution is created which typically shares many of the characteristics of its "parents". New parents are selected for each new child, and the process continues until a new population of solutions of appropriate size is generated. 

**Algorithm for choosing parents** is often similiar to selection algorithm. 

The main function of this stage is to mix the features of the parents in proper way.

**Type** of crossovers:
* Parent amount
  - one parent (cloning) 
  - two parents (traditional)
  - many parents 
* Algorithms
  - select random feature from parents
  - select half of features from first parent and half from second
  - select crossover point (not necessarily one), by which feater from parents will be choosen
  ![](https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/TwoPointCrossover.svg/226px-TwoPointCrossover.svg.png)
  - if there are more than two parents you can do crossover with all parent or pair with two(not necessarily) until each parent takes part
  - etc
  
There are a lot of ways to **store data**:
  * varibles
  * array (sometimes called **chromosomes**)
  * encapsulate in **Brain** class
  * encapsulate in **DNA** class
  * etc

The data is the choice between a **phenotype** (how it behaves) and a **genotype** (how it looks).

**Remark**

In some genetic algorithms, not all possible chromosomes represent valid solutions. In some cases, it is possible to use specialized crossover and mutation operators that are designed to avoid violating the constraints of the problem. 

For example, a genetic algorithm solving the travelling salesman problem may use an ordered list of cities to represent a solution path. Such a chromosome only represents a valid solution if the list contains all the cities that the salesman must visit. Using the above crossovers will often result in chromosomes that violate that constraint. Genetic algorithms optimizing the ordering of a given list thus require different crossover operators that will avoid generating invalid solutions.
  
### Mutation

The mutation process slightly changes the data.

The problem of genetic algorithms is the lack of diversity in individuals. So you probably want to choose not from selected population but from all population *or* increase mutation rate. 

**Varieties** of mutations:
* the population has **N** mutants
* everyone is slightly mutant
* everyone has a slight chance to mutate
* no mutants at all

### Termination

This generational process is repeated until a termination condition has been reached. 

Common terminating **conditions** are:
* a solution is found that satisfies minimum criteria
* fixed number of generations reached
* allocated budget (computation time/money) reached
* the highest ranking solution's fitness is reaching or has reached a plateau such that successive iterations no longer produce better results
* manual inspection
* combinations of the above
* etc

## Remark

Not necessarily all parts of the algorithm must be present in the code. Some steps may be missed, some — implemented in pairs. You also can add your own functions.

For example:
* if representer clone itself over time, there is no needs in fitness function, the longer they live, the higher chance to do cloning
* if task has only one solution, it could be no mutation at all
* the evaluation, selection, crossovering and mutation could be implemented as one algorithm
* the order: crossovering, mutation, evaluation and selction is still valid
* etc


## Glossary
* **Terms**
  - Population — a special data structure which contain all the organisms of the same group and functions for the work of the genetic algorithm
  - Individual (Representer) — a special data structure which represent an individual of population, and meets all the rules of the algorithm
  - Generation — the period during which one iteration of the genetic algorithm occurs
* **Names of variables**
  - Generation count — the number of iterations made by the genetic algorithm
  - Max generation — the maximum number of iterations of the genetic algorithm, often a sign of the completion of the algorithm
  - Population size — the constant size of the population in each generation after selection
  - Children amount — the number of children in each individual after crossing, could be common to the entire population or different for every representer
  - Mutation rate — the number of changes in the offspring, more often as the chance of change
  - Fitness value — adaptability of the individual, determine the chance to go to a new generation or grow children
  - Brain (chromosomes, DNA, phenotype, genotype) — variables which stored the data of representer
* **Names of function**
  - Initialization() (Randomize()) — a function that implement the initialization operator
  - Calculate fitness() (Fitness function()) — a function that implement the evaluating operator
  - Selection() — a function that implement the selection operator
  - Crossover() (Grow children(), Clone(), Copy()) — a function that implement the propagation operator
  - Mutate() (Transform()) — a function that implement the mutation operator
  - Normalization() — a function that changes fitness value within the specified limits
