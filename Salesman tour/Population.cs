using System;
using System.Collections.Generic;
using static Salesman_tour.CityModel;

namespace Salesman_tour
{
    class Population
    {
        // Representor of the population
        public class Individual
        {
            // FIELDS
            Random rand;
            int[] tour; 
            double cost;
            int MutationRate;

            // PROPERTIES
            public double Cost => cost;
            public int[] Tour => tour;
            public int MutationRateProp
            {
                set
                {
                    MutationRate = value;
                }
                get
                {
                    return MutationRate;
                }
            }

            // CONSTRUCTORS
            public Individual(City[] Cities): this(Cities, 0)
            {
                MutationRate = rand.Next(0, 50);
            }

            public Individual(City[] Cities, int Mutation)
            {
                rand = new Random();
                tour = TourModel.FormTour(Cities.Length);
                cost = TourModel.Cost(tour, Cities);
                MutationRate = Mutation;
            }
            
            public Individual(int[] Tour, double Cost, int Mutation)
            {
                rand = new Random();
                tour = Tour.Clone() as int[];
                cost = Cost;
                MutationRate = Mutation;
            } 

            // METHODS
            public Individual GrowChildren(City[] Cities)
            {
                Individual children = this.MemberwiseClone() as Individual;
                children.tour = this.tour.Clone() as int[];

                Transform(children);
                children.cost = TourModel.Cost(children.tour, Cities);
                return children;
            }
            private void Transform(Individual children)
            {
                for(int i = 0; i < MutationRate; ++i)
                {
                    // swap 2 random cities index in tour
                    int l = rand.Next(0, tour.Length);
                    int r = rand.Next(0, tour.Length);

                    int temp = children.tour[l];
                    children.tour[l] = children.tour[r];
                    children.tour[r] = temp;
                } 
            }
            
        }

        // FIELDS
        int childrenAmount;// how much classes produce representor
        int populationSize;// how much representor can be in population
        LinkedList<Individual> PopulationList; // sorted list of representor
        City[] CitiesMap;

        // PROPERTIES
        public LinkedList<Individual> List => PopulationList;
        public int PopulationSize 
        {
            set
            {
                populationSize = value;
            }
        }
        public int ChildrenAmount
        {
            set
            {
                childrenAmount = value;
            }
        }
        public int MutationRate
        {
            set
            {
                foreach(Individual element in PopulationList)
                {
                    element.MutationRateProp = value;
                }
            }
            get
            {
                return PopulationList.First.Value.MutationRateProp;
            }
        }

        // CONSTRUCTORS
        public Population(int PopulationSize, int ChildrenAmount, int MutationRate, City[] CitiesMap)
            :this(PopulationSize, ChildrenAmount, MutationRate, CitiesMap, null)
        {
            PopulationList = new LinkedList<Individual>();
            PopulationList.AddFirst(new Individual(CitiesMap));// first node, so insert algorithm look the same in all cases

            for (int i = 0; i < populationSize; ++i)
            {
                Individual element = new Individual(CitiesMap, MutationRate);
                Insert(element);
            }
        }
        

        public Population(int PopulationSize, int ChildrenAmount, int MutationRate, City[] CitiesMap, LinkedList<Individual> PopulationList)
        {
            this.populationSize = PopulationSize;
            this.childrenAmount = ChildrenAmount;
            this.PopulationList = PopulationList;
            this.CitiesMap = CitiesMap;
        }

        // METHODS
        public void Insert(Individual element)
        {
            LinkedListNode<Individual> node = PopulationList.First;

            while (node.Next != null && node.Value.Cost < element.Cost)
            {
                node = node.Next;
            }
            PopulationList.AddBefore(node, element);
        }
        public void InsertRange(IEnumerable<Individual> range)
        {
            foreach(Individual element in range)
            {
                Insert(element);
            }
        }

        public void GrowChildren()
        {
            List<Individual> children = new List<Individual>(populationSize * childrenAmount);

            foreach(Individual parent in PopulationList)
            {
                for(int i = 0; i < childrenAmount; ++i)
                {
                    children.Add(parent.GrowChildren(CitiesMap));
                }
            }

            InsertRange(children);
            KillWeak();
        }
        private void KillWeak()
        {
            while (PopulationList.Count != populationSize)
            {
                PopulationList.RemoveLast();
            }
        }
    }
}
