using static logicalOperatorsClassifier.Models.Derivatives;
using static logicalOperatorsClassifier.Models.ActivationFunctions;
using MathFunc = System.Func<double, double>;

namespace logicalOperatorsClassifier.Models
{
    // contains functions and their derivatives
    static class FunctionList
    {
        static System.Collections.Generic.Dictionary<MathFunc, MathFunc> map
            = new System.Collections.Generic.Dictionary<MathFunc, MathFunc>()
            {
                [Identity] = dIdentity,
                [Sigmoid] = dSigmoid,
                [Tanh] = dTanh,
                [ArcTan] = dArcTan,
                [Softsign] = dSoftsign,
                [Relu] = dRelu,
                [Leaky_Relu] = dLeakyRelu,
            };
        public static MathFunc GetDerivative(MathFunc f)
        {
            return map[f];
        }
    }
}
