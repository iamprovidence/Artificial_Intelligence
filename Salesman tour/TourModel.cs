using System.Linq;
using System.Drawing;

namespace Salesman_tour
{
    static class TourModel
    {
        static System.Random random = new System.Random();
        // Tour is an integer array which consist of an indexis of the city
        public static int[] FormTour(int CityAmount)
        {
            return Enumerable.Range(0, CityAmount).OrderBy(x => random.Next()).ToArray();
        }
        // Calculate tour cost as a sum of distances between cities
        public static double Cost(int[] tour, CityModel.City[] cities)
        {
            double Length = 0;

            for(int i = 0; i < tour.Length - 1; ++i)
            {
                int CurrentCity = tour[i];
                int NextCity = tour[i + 1];
                Length += CityModel.distance(cities[CurrentCity], cities[NextCity]);
            }
            // dont forget to calculate path from last city to first
            // we need to return to our home
            Length += CityModel.distance(cities[tour.First()], cities[tour.Last()]);
            return Length;
        }
        public static Point[] GetWay(int[] tour, CityModel.City[] CitiesToVisit)
        {
            Point[] way = new Point[tour.Length];
            for (int i = 0; i < tour.Length; ++i)
            {
                way[i] = CitiesToVisit[tour[i]].Coordinate;
            }
            return way;
        }
    }
}
