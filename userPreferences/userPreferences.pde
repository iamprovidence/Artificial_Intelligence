Population p;

void setup()
{
  size(1250, 250);
  p = new Population(6);
  p.add(new Face(10));
  p.add(new Face(215));
  p.add(new Face(420));
  p.add(new Face(625));
  p.add(new Face(830));  
  p.add(new Face(1035));  
}

void draw()
{
  background(180);
  p.update();
};
