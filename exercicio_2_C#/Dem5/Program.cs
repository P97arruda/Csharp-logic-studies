
using System.ComponentModel.Design;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que peça tres numeros ao utilozador e indiquei qual e p menor.

            int numero1, numero2, numero3;

            Console.WriteLine("Insira o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());


            if (numero1 < numero2)
            {
                if (numero2 < numero3)
                {
                    Console.WriteLine($"O primeiro, {numero1} é o mais pequeno de todos");
                }
                else
                {
                    Console.WriteLine($"O terceiro, {numero3} é o mais pequeno de todos");
                }
            }
            else
            {
                if (numero2 < numero3)
                {
                    Console.WriteLine($"O segundo, {numero2} é o mais pequeno de todos.");
                }
                else
                {
                    Console.WriteLine($"O terceiro, {numero3} é o mais pequeno de todos");
                }
            }
        }
    }
}