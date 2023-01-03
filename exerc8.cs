/* Ler nome, endereço e telefone e imprimi-los. */

 using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {

            //* Ler nome, endereço e telefone e imprimi-los.
            double telefone;
            string nome, endereco;


            Console.WriteLine("Informe seu nome");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Informe seu endereço");
            endereco = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Informe seu telefone");
            telefone = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("O nome é " + nome + " o endereço é " + endereco + " e o telefone é " + telefone);
        }
    }
}
