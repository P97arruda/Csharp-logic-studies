using System;
using System.Net;
using System.Xml.Linq;

namespace Dem2
{
    internal class Program
    {
        //2. Pretende-se um programa em C# capaz de ler uma matriz de 10*10 e escrever:
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

            //O maior elemento de cada linha da matriz

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

                Console.WriteLine($" Linha: {i + 1} -  O maior numero: {numeroMaior[i, 0]}");
            }

            Console.WriteLine("Pressione qualquer tecla para ver a A média dos elementos de cada coluna");
            Console.ReadKey();
            Console.Clear();

            // b) A média dos elementos de cada coluna;



            double[] media = new double[10];

            for (int i = 0; i < 10; i++)
            {
                int soma = 0;

                for (int j = 0; j < 10; j++)
                {
                    soma += numeros[i, j];
                }
                media[i] = soma / 10.0;
                Console.WriteLine($" Linha: {i + 1} - Media: {Math.Round(media[i], 2)}");


            }

            Console.WriteLine("Pressione qualquer tecla para ver a a soma dos elementos da linha 3.");
            Console.ReadKey();
            Console.Clear();

            // c) A soma dos elementos da linha 3;

            int linha = 2;
            int somaLinha = 0;

            for (int j = 0; j < 10; j++)
            {
                somaLinha += numeros[linha, j];
            }

            Console.WriteLine($"A soma dos numeros da linha 3: {somaLinha}");

            Console.WriteLine("Pressione qualquer tecla para ver a soma dos elementos de uma coluna escolhida pelo ultilizador.");
            Console.ReadKey();
            Console.Clear();

            // d) A soma dos elementos de uma coluna escolhida pelo utilizador;

            int coluna;
            int somaColuna = 0;

            Console.Write("Qual coluna voce gostaria de ver a soma: ");
            int.TryParse(Console.ReadLine(), out coluna);

            coluna--;

            for (int i = 0; i < 10; i++)
            {
                somaColuna += numeros[i, coluna];
            }

            Console.WriteLine($"A coluna escolhida foi: {coluna + 1} é a soma e: {somaColuna}");


            Console.WriteLine("Pressione qualquer tecla para ver a soma dos elementos da diagonal principal.");
            Console.ReadKey();
            Console.Clear();

            //e) A soma dos elementos da diagonal principal;


            int somaDiagonal = 0;

            for (int i = 0; i < 10; i++)
            {
                somaDiagonal += numeros[i, i];
            }

            Console.WriteLine($"A soma dos elementos da diagonal princial: {somaDiagonal}");


            Console.WriteLine("Pressione qualquer tecla para ver a soma dos elementos de toda a matriz.");
            Console.ReadKey();
            Console.Clear();


            // f) A soma dos elementos de toda a matriz;

            int somaMatriz = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    somaMatriz += numeros[i, j];
                }

            }

            Console.WriteLine($"A soma dos elementos de toda a matriz: {somaMatriz}");


            Console.WriteLine("Pressione qualquer tecla para ver os números de elementos da matriz iguais a um número dado.");
            Console.ReadKey();
            Console.Clear();

            //g) Os números de elementos da matriz iguais a um número dado;
            
            int numeroDado ;
            int qNumeroDado = 0;

            Console.Write("insira um numero: ");
            int.TryParse(Console.ReadLine(), out numeroDado);
            
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    if(numeroDado == numeros[i, j])
                    {
                       qNumeroDado++;
                    }
                }
            }
            Console.WriteLine($"O numero dado {numeroDado} a quantidade de igual ao elemento dado: {qNumeroDado}");


            Console.WriteLine("Pressione qualquer tecla para ver a mundaça de elementos de uma matriz.");
            Console.ReadKey();
            Console.Clear();

            //h) A mudança de posição de todos os elementos da matriz, trocando o número da linha pela
            //coluna.Exemplo: o elemento da linha 3 coluna 5, passa para a coluna 3 linha 5


            int[,] ntrocados = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    
                        ntrocados[j, i] = numeros[i, j];
                    
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(ntrocados[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}


