using System;

namespace logicalOperatorsClassifier.Models
{
    class VectorTranspose
    {
        // FIELDS
        double[] elements;
        // CONSTRUCTORS
        public VectorTranspose(int cols)
        {
            this.elements = new double[cols];
        }
        public VectorTranspose(double[] el)
        {
            this.elements = new double[el.Length];
            Array.Copy(el, elements, el.Length);
        }
        // PROPERTIES
        public int Cols => elements.Length;
        // INDEXERS
        public double this[int i]
        {
            get { return elements[i]; }
            set { elements[i] = value; }
        }
        // METHODS
        public static Matrix operator *(Vector v, VectorTranspose vt)
        {
            Matrix res = new Matrix(v.Rows, vt.Cols);

            for(int i = 0; i < v.Rows; ++i)
            {
                for(int j = 0; j < vt.Cols; ++j)
                {
                    res[i, j] = v[i] * vt[j];
                }
            }

            return res;
        }
    }
}
