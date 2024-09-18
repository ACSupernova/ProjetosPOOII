using System;
using System.Collections.Generic;

class Program{
  public static void Main(string[] args){
    /*
    Collections:
    - Lists: (List<T>): Ordenadas, indexadas, mutáveis e permite duplicatas.
    - 
    */
    List<string> fruits = new List<string> {"Apple", "Banana", "Orange", "Lemon"};
      
    fruits.Add("Pineapple");
      Console.WriteLine(fruits[2]);
      
    fruits.Remove("Orange");
      Console.WriteLine(fruits[2]);
      
    fruits.Insert(2, "Strawberry");
      Console.WriteLine(fruits[2]);

     Console.WriteLine("\n## Imprimindo com For ##\n");
    for(int i = 0; i < fruits.Count; i++){
      Console.WriteLine(i + " - " + fruits[i]);
    }
  }
}