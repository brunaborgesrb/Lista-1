/* Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem:
Soma. */

using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {

            //*  Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma.
            int num1, num2, soma;


            Console.WriteLine("Informe um número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = (num1 + num2);

            Console.WriteLine("O primeiro número é " + num1 + "o segundo número é " + num2 + " e a soma dos dois é " + soma);
        }
    }
}
