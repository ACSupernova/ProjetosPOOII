/*
1) Crie uma classse chamada carro que tenha propriedade "posição".
2) Crie métodos sobrecarregados chamado deslocar qe calcule a posição final do carro após um deslocamento.
3) Crie um programa executável que instancie um carro e faça deslocamentos tanto em MRU quanto em MRV
*/

using System;

class Car{
  public double Position{get ; set ;}

  public void Move(double v, double t){
    Position = Position + v * t;
  }

  public void Move(double v, double t, double a){
    Position = Position + v * t + (a * t * t)/2;
  }
}

class Program{
  static void Main(string[] args){
    Car c = new Car();
    c.Position = 10;

    c.Move(5, 5);
    Console.WriteLine("A posição atual é " + c.Position);
  }
}