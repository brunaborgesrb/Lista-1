/*  Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%. */

using System;

class Program {
  public static void Main (string[] args) {
    
	//   Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%.

    
   	double saldo, novoSaldo;
   	Console.WriteLine("Informe o saldo");
   	saldo = Convert.ToDouble(Console.ReadLine());

   	novoSaldo = (saldo * 0.01);

	Console.WriteLine("O novo saldo é de " + novoSaldo);

    
  }
}
