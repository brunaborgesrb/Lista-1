/*  Entrar com as notas da PR1 e PR2 e imprimir a média final. */

using System;

class Program {
  public static void Main (string[] args) {
    
	//  Entrar com as notas da PR1 e PR2 e imprimir a média final.
    
  	int PR1, PR2, media;
  	Console.WriteLine ("Informe a primeira nota");
  	PR1 = Convert.ToInt32(Console.ReadLine());
  	Console.WriteLine("Informe a segunda nota");
  	PR2 = Convert.ToInt32(Console.ReadLine());

	media = (PR1 + PR2) / 2;
	Console.WriteLine("Média final= " + media);
  }
}
