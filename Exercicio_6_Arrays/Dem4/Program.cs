using System.Runtime.Serialization;

namespace Dem4
{
    internal class Program
    {
        //4. Elabore um programa que calcule: 
        //a) O somatório de todos os elementos de um array com N números.
        //b) A média aritmética de todos os elementos de um array de N números.

        static void Main(string[] args)
        {
            int quantidade;
            int soma = 0;
            double media = 0;

            Console.Write("Insira o tamanho do Array: ");
            int.TryParse(Console.ReadLine(), out quantidade);

            int[] numero = new int[quantidade];

           for (int i = 0; i <numero.Length; i++)
           {
                do
                {
                    Console.Write($"Insira um numero: {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out numero[i]));
            }

            for (int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
                
            }
                media = soma / quantidade;

            Console.WriteLine($"A soma dos numeros é: {soma}");
           Console.WriteLine($"A média dos numeros é: {Math.Round(media, 2)}");
        }
    }
}
