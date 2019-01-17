class Matrix 
{
  // FIELDS
  private int rows;
  private int cols;
  private float[][] data;
  // CONSTRUCTORS
  Matrix(float[] vector)
  {
    this.rows = vector.length;
    this.cols = 1;
    this.data = new float[rows][cols];
    for (int i = 0; i < rows; ++i)
    {
      data[i][0] = vector[i];
    }
  }
  Matrix(int rows, int cols) 
  {
    this.rows = rows;
    this.cols = cols;
    this.data = new float[rows][cols];
  }
  Matrix randomize(int min, int max) 
  {
    for(int i = 0; i < rows; ++i)
    {
      for(int j = 0; j < cols; ++j)
      {
        data[i][j] = random(min, max);
      }
    }
    return this;
  }
  Matrix randomize(int max) 
  {
    return randomize(0, max);
  }
  Matrix randomize() 
  {
    return randomize(0, Integer.MAX_VALUE);
  }
  Matrix fill(float value) 
  {
    for(int i = 0; i < rows; ++i)
    {
      for(int j = 0; j < cols; ++j)
      {
        data[i][j] = value;
      }
    }
    return this;
  }
  Matrix copy() 
  {
    Matrix clone = new Matrix(this.rows, this.cols);
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j) 
      {
        clone.data[i][j] = this.data[i][j];
      }
    }
    return clone;
  }
  float[] toArray()
  {
    float[] arr = new float[rows * cols];
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j)
      {
        arr[i*cols + j] = data[i][j];
      }
    }
    return arr;
  }
  // METHODS
  Matrix transpose()
  {
    Matrix res = new Matrix(this.cols, this.rows);
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j)
      {
        res.data[j][i] = this.data[i][j];
      }
    }
    return res;    
  }
  Matrix mutate(float min, float max, float chance)
  {
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j)
      {
        // mutation
        if (chance < random(1))
        {
          data[i][j] += random(min, max);
        }
      }
    }
    return this;    
  }
  // OPERATIONS
  Matrix add(Matrix b)
  {
    if (this.rows != b.rows || this.cols != b.cols) 
    {
      throw new ArithmeticException("Columns and Rows of A must match Columns and Rows of B.");
    }
    // Return a new Matrix a+b
    Matrix res = new Matrix(this.rows, this.cols);
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j)
      {
        res.data[i][j] = this.data[i][j] + b.data[i][j];
      }
    }
    return res;
  }
  Matrix subtract(Matrix b)
  {
    if (this.rows != b.rows || this.cols != b.cols) 
    {
      throw new ArithmeticException("Columns and Rows of A must match Columns and Rows of B.");
    }

    // Return a new Matrix a-b
    Matrix res = new Matrix(this.rows, this.cols);
    for (int i = 0; i < this.rows; ++i) 
    {
      for (int j = 0; j < this.cols; ++j)
      {
        res.data[i][j] = this.data[i][j] - b.data[i][j];
      }
    }
    return res;
  }
  Matrix multiplying(Matrix b)
  {
    if (this.cols != b.rows) 
    {
      println("A cols = " + this.cols);
      println("B rows = " + b.rows);
      
      throw new ArithmeticException("Cols of A must match Rows of B.");
    }
    
    // Return a new Matrix a*b
    Matrix res = new Matrix(this.rows, b.cols);
    for (int i = 0; i < this.rows; ++i) 
    {  
        for (int j = 0; j < b.cols; ++j) 
        {  
            float sum = 0;
            for (int k = 0; k < this.cols; ++k) 
            {  
                sum += this.data[i][k] * b.data[k][j];  
            }  
            res.data[i][j] = sum; 
        }  
    }
    return res;
  }
  Matrix multiplying(float val)
  {
    // Return a new Matrix a*val
    Matrix res = new Matrix(this.rows, this.cols);
    for (int i = 0; i < this.rows; ++i) 
    {  
        for (int j = 0; j < this.cols; ++j) 
        {              
            res.data[i][j] = this.data[i][j] * val; 
        }  
    }
    return res;
  }
  Matrix dotMultiplying(Matrix b)
  {
    if (this.rows != b.rows || this.cols != b.cols) 
    {
      throw new ArithmeticException("Columns and Rows of A must match Columns and Rows of B.");
    }
    // Return a new Matrix a o b
    Matrix res = new Matrix(this.rows, this.cols);
    for (int i = 0; i < this.rows; ++i) 
    {  
        for (int j = 0; j < this.cols; ++j) 
        {              
            res.data[i][j] = this.data[i][j] * b.data[i][j]; 
        }  
    }
    return res;
  }
  // GET SET
  int cols() { return cols; }
  int rows() { return rows; }
  float get(int i, int j) { return data[i][j]; }
  void set(int i, int j, float value) { data[i][j] = value; }
}
