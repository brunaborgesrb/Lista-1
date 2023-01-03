/*  Ler dois números inteiros e imprimi-los. */

using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {

            //* Ler dois números inteiros e imprimi-los.
            int numInteiro1, numInteiro2;
            Console.WriteLine("Informe um número inteiro");
            numInteiro1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro número inteiro");
            numInteiro2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número inteiro é " + numInteiro1 + " e o outro é " + numInteiro2);
        }
    }
}
