using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Dem2
{
    internal class Program
    {
        // 2. Elabore um programa que leia um vetor com um número desconhecido de elementos e os mostre.
        // Utilize o 999 para terminar a digitação dos dados.
        static void Main(string[] args)
        {
            int[] numero = new int[999];
            int valor = 0;
            int i = 0;

            Console.WriteLine("insira 999 Para termina o ciclo");

            for (i = 0; i < numero.Length && valor != 999; i++) 
            {
               do 
               {
                   Console.Write($" Insira um numero: {i + 1}: ");

                } while (!int.TryParse(Console.ReadLine(), out valor));

                numero[i] = valor;

            }

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($" Os Numeros que estão dentro do Array: {j + 1} e: {numero[j]}");
            }





            

          //  while (valor != 999)  
          //   {
          //      numero[i] = valor;
          //      i++;

          //     Console.Write($"Insira um numero {i + 1}: ");
          //     int.TryParse(Console.ReadLine() , out valor);
          //   }

          //Console.WriteLine("Os numeros dentros Array");

          //  for (int j = 0; j < i; j++)
          //  {
          //     Console.WriteLine($"Posição {j + 1}: {numero[j]}");
          //  }
        }
    }
}
