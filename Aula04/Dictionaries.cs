/*
Collections: 
- Dictionaries(Dictionary<Tkey, TValue>): Tamanh fixo, não ordenado, não indexado, não mutável e permite duplicatas. (Chave e valor)
*/

using System;
using System.Collections.Generic;

class program{
 public static void Main(string[] args){
    Dictionary<string, int> idades = new Dictionary<string, int>();

  idades.Add("Alice", 25);
  idades.Add("Zacarias", 71);
  idades.Add("Mario", 22);

   Console.WriteLine("Zacarias tem " + idades["Zacarias"]);

foreach (KeyValuePair<string, int> pair in idades){
  Console.WriteLine(pair.Key + " possui " + pair.Value + " anos.");
}
    }
}