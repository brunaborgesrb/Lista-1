/* Ler um número inteiro e imprimir seu sucessor e seu antecessor. */

using System;

class Program {
  public static void Main (string[] args) {
    
	//   Ler um número inteiro e imprimir seu sucessor e seu antecessor.
    
   	int numInteiro, antecessor, sucessor;
   	Console.WriteLine("Informe um número inteiro");
   	numInteiro = Convert.ToInt32(Console.ReadLine());

   	antecessor = numInteiro - 1;
   	sucessor = numInteiro + 1;


	Console.WriteLine("O número é " + numInteiro + " o antecessor é " + antecessor + " e o sucessor é " + sucessor);

    
  }
}
