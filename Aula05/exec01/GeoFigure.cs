using System;

public abstract class GeoFigure{

  public abstract double CalculateArea();
  
  public virtual double CalculatePerimeter(){
    return 0;
  }
  
  public virtual double CalculateVolume(){
    return 0;
  }
}