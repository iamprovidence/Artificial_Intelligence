using static logicalOperatorsClassifier.Models.FunctionList;
using MathFunc = System.Func<double, double>;

namespace logicalOperatorsClassifier.Models
{
    class ActivationFunction
    {
        // FIELDS
        MathFunc func;
        MathFunc deriv;
        // PROPERTIES
        public MathFunc Func
        {
            get
            {
                return func;
            }
            set
            {
                this.func = value;
                this.deriv = GetDerivative(value);
            }
        }
        public MathFunc Deriv => deriv;
        // CONSTRUCTORS
        public ActivationFunction(MathFunc func)
        {
            Func = func;
        }
    }
}
