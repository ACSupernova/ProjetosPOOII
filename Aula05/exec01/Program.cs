using System;

class Program{
  public static void Main(string[] args){
    GeoFigure c = new Circle(2);
    Console.WriteLine("A area do circulo é: " + c.CalculateArea());
    Console.WriteLine("O volume do circulo é: " + c.CalculateVolume());

    GeoFigure j = new Triangle(3, 8);
    Console.WriteLine("O perimetro é: " + c.CalculatePerimeter());
  }
}