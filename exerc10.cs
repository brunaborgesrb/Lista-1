/* Ler dois números inteiros e imprimir o produto. */

using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {

            //*  Ler dois números inteiros e imprimir o produto.
            int num1, num2;


            Console.WriteLine("Informe um número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro número");
            num2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("O primeiro número é " + num1 + "o segundo número é " + num2);
        }
    }
}

