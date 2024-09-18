using System;

class Circle : GeoFigure{
  public double Radius { get; }

  public Circle (double radius){
    Radius = radius;
  }

  public override double CalculatePerimeter(){
    return 2 * Math.PI * Radius;
  }

  public override double CalculateArea(){
    return Math.PI * Radius * Radius;
  }
  
}