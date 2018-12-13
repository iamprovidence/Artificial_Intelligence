class ObjectInfo
{
  // FIELDS
  private int mapAmount;
  private int collectedAmount;
  private color objectColor;
  // CONSTRUCTORS
  ObjectInfo(int mapAmount, int collectedAmount, color objectColor)
  {
    this.mapAmount = mapAmount;
    this.collectedAmount = collectedAmount;
    this.objectColor = objectColor;
  }
  // METHODS
  void setColor(color objectColor)
  {
    this.objectColor = objectColor;
  }
  void setMapAmount(int value)
  {
    mapAmount = value;
  }
  void addToCollectedAmount(int value)
  {
    collectedAmount += value;
  }
  color getColor()
  {
    return objectColor;
  }
  int getAmount()
  {
    return mapAmount;
  }
  int getCollected()
  {
    return collectedAmount;
  }
}
