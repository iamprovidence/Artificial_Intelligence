using static System.Math;
using static logicalOperatorsClassifier.Models.ActivationFunctions;

namespace logicalOperatorsClassifier.Models
{
    static class Derivatives
    {
        public static double dIdentity(double x)
        {
            return 1;
        }
        public static double dSigmoid(double x)
        {
            return Sigmoid(x) * (1 - Sigmoid(x));
        }
        public static double dTanh(double x)
        {
            return 1 - Pow(System.Math.Tanh(x), 2);
        }
        public static double dArcTan(double x)
        {
            return 1 / (Pow(x, 2) + 1);
        }
        public static double dSoftsign(double x)
        {
            return 1 / Pow((1 + Abs(x)), 2);
        }
        public static double dRelu(double x)
        {
            if (x >= 0) return 1;
            return 0;
        }
        public static double dLeakyRelu(double x)
        {
            if (x >= 0) return 1;
            return 0.01;
        }
    }
}
