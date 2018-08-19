using static System.Math;

namespace logicalOperatorsClassifier.Models
{
    static class ActivationFunctions
    {
        public static double Identity(double x)
        {
            return x;
        }
        public static double Sigmoid(double x)
        {
            return 1 / (1 + Pow(E, -x));
        }
        public static double Tanh(double x)
        {
            return System.Math.Tanh(x);
        }
        public static double ArcTan(double x)
        {
            return Atan(x);
        }
        public static double Softsign(double x)
        {
            return 1 / (1 + Abs(x));
        }
        public static double Relu(double x)
        {
            if (x >= 0) return x;
            return 0;
        }
        public static double Leaky_Relu(double x)
        {
            if (x >= 0) return x;
            return 0.01 * x;
        }
    }
}