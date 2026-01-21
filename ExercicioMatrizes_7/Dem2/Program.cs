using System;

namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[10, 10];


            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    numeros[i, j] = rand.Next(1, 101);
                    //    do
                    //    {

                    //        Console.Write($"insira um número [{i + 1}, {j + 1}] : ");
                    //    } while(!int.TryParse(Console.ReadLine(), out numeros[i, j]));

                }
            }
            Console.WriteLine();
            Console.WriteLine("Os numeros inseridos na matriz");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para ver o maior elemento de cada linha da matriz");
            Console.ReadKey();
            Console.Clear();

            int[,] numeroMaior = new int[10, 1];

            for (int i = 0; i < 10; i++)
            {
                int maior = numeros[i, 0];

                for (int j = 0; j < 10; j++)
                {
                    if (numeros[i, j] > maior)
                    {
                        maior = numeros[i, j];
                    }
                }

                numeroMaior[i, 0] = maior;

                Console.WriteLine($"Linha {i + 1} - Maior: {numeroMaior[i, 0]}");
            }

            Console.WriteLine("Pressione qualquer tecla para ver a A média dos elementos de cada coluna");
            Console.ReadKey();
            Console.Clear();

            int soma = 0;
            double[] media = new double[10];

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    soma += numeros[i, j];
                }
                media[i] = soma / 10.0;
                Console.WriteLine($" Linha {i + 1} - Media: {Math.Round(media[i], 2)}");


            }   

            Console.WriteLine("Pressione qualquer tecla para ver a a soma dos elementos da linha 3.");
            Console.ReadKey();
            Console.Clear();

            int linha = 2;
            int somaLinha = 0;

            for (int j = 0; j < 10; j++)
            {
                somaLinha += numeros[linha, j]; 
            }

            Console.WriteLine($"A soma dos numeros da linha 3: {somaLinha}");
        }
    }
}


