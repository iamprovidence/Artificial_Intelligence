class ImageAnimator
{
  // FIELDS
  private ArrayList<PImage> images;
  private int index;
  private int amountFrameToAnimate;
  int frame;
  // CONSTRUCTORS
  ImageAnimator(int amountFrameToAnimate)
  {
    images = new ArrayList<PImage>();
    index = 0;
    frame = 0;
    this.amountFrameToAnimate = amountFrameToAnimate;
  }
  // METHODS
  ImageAnimator add(PImage img)
  {
    images.add(img);
    return this;
  }
  PImage nextImage()
  {
    if(frame == amountFrameToAnimate)
    {
      ++ index;
      frame = 0;
      if(index == images.size())
      {
        index = 0;
      }
    }
    ++ frame;
    return images.get(index);
  }
}
