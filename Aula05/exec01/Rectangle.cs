using System;

class Rectangle : GeoFigure{
  public double Height { get; }
  public double Width { get; }

  public Rectangle(double height, double width){
    Height = height;
    Width = width;
  }

  public override double CalculatePerimeter(){
    return 2 (Height + Width);
  }

  public override double CalculateArea(){
    return Height * Width;
  }
  
}