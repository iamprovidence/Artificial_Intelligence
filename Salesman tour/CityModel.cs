using System.Drawing;
using static System.Math;

namespace Salesman_tour
{
    public class CityModel
    {
        static System.Random random = new System.Random();
        public class City
        {
            Point coordinate;

            public City(int X, int Y)
            {
                coordinate = new Point(X, Y);
            }
            public int X => coordinate.X;
            public int Y => coordinate.Y;
            public Point Coordinate => coordinate;
        }
        // Calculate the distance between two cities
        // The same as distances between two points sqrt( (Xb - Xa)^2 + (Yb - Ya)^2)
        public static double distance(City A, City B)
        {
            return Sqrt(Pow(B.X - A.X, 2) + Pow(B.Y - A.Y, 2));
        }
        
        // Generate cities on map in random places
        public static City[] GetCitiesCoordinate(int CityAmount, Size MapSize)
        {
            City[] Cities = new City[CityAmount];
            
            for (int i = 0; i < CityAmount; ++i)
            {
                Cities[i] = new City(X: random.Next(0, MapSize.Width), 
                                     Y: random.Next(0, MapSize.Height));
            }

            return Cities;
        }
    }
}
