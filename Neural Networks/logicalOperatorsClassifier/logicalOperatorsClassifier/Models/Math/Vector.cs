using System;
using System.Linq;

namespace logicalOperatorsClassifier.Models
{
    class Vector
    {
        // FIELDS
        double[] elements;
        // CONSTRUCTORS
        public Vector(int rows)
        {
            this.elements = new double[rows];
        }
        public Vector(int rows, double fillValue)
        {
            this.elements = Enumerable.Repeat(fillValue, rows).ToArray();
        }
        public Vector(double[] el)
        {
            this.elements = new double[el.Length];
            Array.Copy(el, elements, el.Length);
        }
        // PROPERTIES
        public int Rows => elements.Length;
        // INDEXERS
        public double this[int i]
        {
            get { return elements[i]; }
            set { elements[i] = value; }
        }
        // METHODS
        public void Fill(double fillValue)
        {
            this.elements = Enumerable.Repeat(fillValue, elements.Length).ToArray();
        }
        public static Vector operator +(Vector l, Vector r)
        {
            if(l.Rows != r.Rows) throw new Exception("Not the same size");

            return new Vector(l.Rows)
            {
                elements = l.elements.Zip(r.elements, (le, re) => le + re).ToArray()
            };
        }
        public static Vector operator *(Matrix m, Vector v)
        {
            if (m.Cols != v.Rows) throw new Exception("Not the same size");

            Vector res = new Vector(m.Rows);

            for (int i = 0; i < m.Rows; ++i)
            {
                double sum = 0;
                for (int j = 0; j < m.Cols; ++j)
                {
                    sum += m[i, j] * v[j];
                }
                res[i] = sum;
            }

            return res;
        }
        public static Vector operator *(double d, Vector v)
        {
            return new Vector(v.elements.Select(x => x * d).ToArray());
        }
        public static Vector operator *(Vector l, Vector r)
        {
            if (l.Rows != r.Rows) throw new Exception("Not the same size");

            return new Vector(l.Rows)
            {
                elements = l.elements.Zip(r.elements, (lv, rv) => lv * rv).ToArray()
            };
        }
        public Vector TransformEach(Func<double, double> f)
        {
            return new Vector(this.Rows)
            {
                elements = this.elements.Select(x => f(x)).ToArray()
            };
        }
        public double[] ToArray()
        {
            return elements.Clone() as double[];
        }
        public static VectorTranspose Transpose(Vector v)
        {
            return new VectorTranspose(v.elements);
        }
    }
}
