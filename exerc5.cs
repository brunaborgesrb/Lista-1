/* Ler um número inteiro e imprimi-lo */

 using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {

            //*Ler um número inteiro e imprimi-lo
            int numInteiro;
            Console.WriteLine("Informe um número inteiro");
            numInteiro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número inteiro é " + numInteiro);
        }
    }
}
