using System;

class Square : GeoFigure{
  public double Side { get; }

  public Square(double side){
    Side = side;
  }

  public override double CalculatePerimeter(){
    return Side * 4;
  }

  public override double CalculateArea(){
    return Side * Side;
  }
  
}