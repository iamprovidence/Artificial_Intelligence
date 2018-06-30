using System;
using System.Linq;
using System.Collections.Generic;
using static Salesman_tour.CityModel;

namespace Salesman_tour
{
    class HillClimbing
    {
        // FIELDS
        LinkedList<int> notVisited;
        int[] tour;
        int CurrentTourCityIndex;
        City[] Cities;
        bool compleated;

        // PROPERTIES
        public int[] Tour => tour;
        public int[] result => compleated ? tour : null;

        // EVENTS
        public event EventHandler<HillClimbingArgs> lookAtCity;
        public event EventHandler<HillClimbingArgs> ChooseACity;

        // CONSTRUCTORS
        public HillClimbing(City[] Cities, int StartedCity)
        {
            this.notVisited = new LinkedList<int>(Enumerable.Range(0, Cities.Length).Where(x => x != StartedCity));
            this.CurrentTourCityIndex = 0;
            this.Cities = Cities;
            this.tour = new int[Cities.Length];
            this.tour[CurrentTourCityIndex] = StartedCity;
            this.compleated = false;
        }
        /*
         * Return tour[] as the result
         * Get information about result from Events
         */
        public int[] Run()
        {
            LinkedListNode<int> nextCityIndex = null;

            while (notVisited.Count != 0)// while there are cities to visit
            {
                double minDistance = double.MaxValue;
                // foreach unvisited city
                for (var cityIndex = notVisited.First; cityIndex != null; cityIndex = cityIndex.Next)
                {
                    City current = Cities[tour[CurrentTourCityIndex]];
                    City next = Cities[cityIndex.Value];

                    // find the shortest way
                    double currentDistance = CityModel.distance(current, next);
                    lookAtCity?.Invoke(this, new HillClimbingArgs(tour[CurrentTourCityIndex], cityIndex.Value, currentDistance));
                    
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        nextCityIndex = cityIndex;
                    }
                }
                // the shortest way has been found
                ChooseACity?.Invoke(this, new HillClimbingArgs(tour[CurrentTourCityIndex], nextCityIndex.Value, minDistance));
                
                tour[++CurrentTourCityIndex] = nextCityIndex.Value;
                notVisited.Remove(nextCityIndex);
            }

            return tour;
        }
        /*
         * Does not return the tour[], should use propery for that
         * Get information about process from result, works as Enumerator
         */
        public IEnumerable<HillClimbingArgs> RunIter()
        {
            compleated = false;
            LinkedListNode<int> nextCityIndex = null;

            while (notVisited.Count != 0)// while there are cities to visit
            {
                double minDistance = double.MaxValue;
                // foreach unvisited city
                for (var cityIndex = notVisited.First; cityIndex != null; cityIndex = cityIndex.Next)
                {
                    City current = Cities[tour[CurrentTourCityIndex]];
                    City next = Cities[cityIndex.Value];

                    // find the shortest way
                    double currentDistance = CityModel.distance(current, next);
                    yield return new HillClimbingArgs(tour[CurrentTourCityIndex], cityIndex.Value, currentDistance);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        nextCityIndex = cityIndex;
                    }
                }
                // the shortest way has been found
                yield return new HillClimbingArgs(tour[CurrentTourCityIndex], nextCityIndex.Value, minDistance, true);

                tour[++CurrentTourCityIndex] = nextCityIndex.Value;
                notVisited.Remove(nextCityIndex);
            }
            compleated = true;
        }


    }

    class HillClimbingArgs: EventArgs
    {
        // FIELDS
        int currentCityIndex;
        int nextCityIndex;
        double distance;
        bool isChosen;

        // PROPERTIES
        public int CurrentCityIndex => currentCityIndex;
        public int NextCityIndex => nextCityIndex;
        public double Distance => distance;
        public bool IsChosen => isChosen;

        // CONSTRUCTORS
        public HillClimbingArgs(int current, int next):
            this(current, next, 0, false)
        {  }

        public HillClimbingArgs(int current, int next, double distance) :
            this(current, next, distance, false)
        {  }

        public HillClimbingArgs(int current, int next, double distance, bool isChosen)
        {
            this.currentCityIndex = current;
            this.nextCityIndex = next;
            this.distance = distance;
            this.isChosen = isChosen;
        }
    }
}
