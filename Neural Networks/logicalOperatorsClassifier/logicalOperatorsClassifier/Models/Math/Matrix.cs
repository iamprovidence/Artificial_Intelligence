using System;

namespace logicalOperatorsClassifier.Models
{
    class Matrix
    {
        // FIELDS
        Random random;
        double[,] basic;
        int rows;
        int cols;
        // PROPERTIES
        public int Rows => rows;
        public int Cols => cols;
        // CONSTRUCTORS
        public Matrix(int rows, int cols)
        {
            this.random = new Random();
            this.rows = rows;
            this.cols = cols;
            this.basic = new double[rows, cols];
        }
        // INDEXERS
        public double this[int i, int j]
        {
            get { return basic[i, j]; }
            set { basic[i, j] = value; }
        }
        // METHODS
        public static Matrix Transpose(Matrix m)
        {
            Matrix res = new Matrix(m.cols, m.rows);
            for (int i = 0; i < m.rows; ++i)
            {
                for (int j = 0; j < m.cols; ++j)
                {
                    res[j, i] = m[i, j];
                }
            }
            return res;
        }
        /// <summary>
        /// This fills the matrix with random values.
        /// Default: gaussian distribution.
        /// </summary>
        public Matrix randomize(double min = -1, double max = 1)
        {
            for (int i = 0; i < this.rows; ++i)
            {
                for (int j = 0; j < this.cols; ++j)
                {
                    basic[i, j] = random.NextDouble() * (max - min) + min;
                }
            }
            return this;
        }
        // OPERATORS
        public static Matrix operator +(Matrix l, Matrix r)
        {
            if (l.rows != r.rows || l.cols != r.cols) throw new Exception("Not the same size");

            Matrix res = new Matrix(l.rows, l.cols);
            for (int i = 0; i < res.rows; ++i)
            {
                for (int j = 0; j < res.cols; ++j)
                {
                    res[i, j] = l[i, j] + r[i, j];
                }
            }
            return res;
        }
        public static Matrix operator -(Matrix l, Matrix r)
        {
            if (l.rows != r.rows || l.cols != r.cols) throw new Exception("Not the same size");

            Matrix res = new Matrix(l.rows, l.cols);
            for (int i = 0; i < res.rows; ++i)
            {
                for (int j = 0; j < res.cols; ++j)
                {
                    res[i, j] = l[i, j] - r[i, j];
                }
            }
            return res;
        }
        public static Matrix operator *(int l, Matrix r)
        {
            Matrix res = new Matrix(r.rows, r.cols);
            for (int i = 0; i < res.rows; ++i)
            {
                for (int j = 0; j < r.cols; ++j)
                {
                    res[i, j] *= l;
                }
            }
            return res;
        }
        public static Matrix operator *(Matrix l, int r)
        {
            return r * l;
        }
        public static Matrix operator *(Matrix l, Matrix r)
        {
            if (l.cols != r.rows) throw new Exception("Not the same size");

            Matrix res = new Matrix(l.rows, r.cols);

            for (int i = 0; i < l.rows; ++i)
            {
                for (int j = 0; j < r.cols; ++j)
                {
                    double s = 0.0;
                    for (int k = 0; k < l.cols; ++k)
                    {
                        s += l[i, k] * r[k, j];
                    }
                    res[i, j] = s;
                }
            }

            return res;
        }

    }
}
