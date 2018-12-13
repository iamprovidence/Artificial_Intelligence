class MyGrid
{
  // FIELDS
  private int col;
  private int row;  
  private Window[][] windows;
  // CONSTRUCTORS
  MyGrid (int row, int col)
  {
    this.row = row;
    this.col = col;
    this.windows = new Window[col][row];
    
    float rowHeight = height / row;
    float colWidth = width / col;
    for (int i = 0; i < col; ++i)
    {
      for (int j = 0; j < row; ++j)
      {
        windows[i][j] = new Window(new Point(i * colWidth, j * rowHeight),new Point((i+1) * colWidth, (j+1) * rowHeight));
      }
    }
  }
  // METHODS
  Window getWindow(int i, int j)
  {
    return windows[j][i];
  }
  void setWindowColor(int i, int j, color windowColor)
  {
    windows[j][i].setColor(windowColor);
  }
  void show()
  {
    for (int i = 0; i < col; ++i)
    {
      for (int j = 0; j < row; ++j)
      {
        windows[i][j].show();
      }
    }
  }
}
