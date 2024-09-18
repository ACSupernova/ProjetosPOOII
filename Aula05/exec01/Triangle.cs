using System;

class Triangle : GeoFigure{
  public double HeightT { get; }
  public double WidthT { get; }

  public Triangle (double heightT, dobule widthT){
    HeightT = heightT;
    WidthT = widthT;
  }

  public override double CalculatePerimeter(){
    return WidthT + Math.Sqrt(Math.pow((WidthT/2), 2) + Math.Pow(Height, 2)) * 2;
  }

  public override double CalculateArea(){
    return (WidthT * HeightT) / 2;
  }
  
}