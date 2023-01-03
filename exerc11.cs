/*  Ler um número real (numero com vírgula) e imprimir a terça parte deste número. */

using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {

            //*  Ler um número real (numero com vírgula) e imprimir a terça parte deste número.
            int numero, numero1;


            Console.WriteLine("Informe um número");
            numero = Convert.ToInt32(Console.ReadLine());

            numero1 = numero / 3;


            Console.WriteLine("A terça parte é " + numero1);
        }
    }
}
