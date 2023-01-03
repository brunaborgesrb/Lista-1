/*  Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.*/

using System;

class Program {
  public static void Main (string[] args) {
    
	// Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.
    
  	int num1, num2, media;
  	Console.WriteLine ("Informe um número");
  	num1 = Convert.ToInt32(Console.ReadLine());
  	Console.WriteLine("Informe outro número");
  	num2 = Convert.ToInt32(Console.ReadLine());

	media = (num1 + num2) / 2;
	Console.WriteLine("Média = " + media);
  }
}
