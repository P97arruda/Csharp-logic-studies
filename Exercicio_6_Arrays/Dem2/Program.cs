using System.Net;

namespace Dem2
{
    internal class Program
    {
        // 2. Elabore um programa que leia um vetor com um número desconhecido de elementos e os mostre.
        // Utilize o 999 para terminar a digitação dos dados.



        static void Main(string[] args)
        {
            int tamanho;

            Console.Write("Insira o tamanho do Array: ");
            int.TryParse(Console.ReadLine(), out tamanho);

            int[] numero = new int[tamanho];

          

        }
    }
}
