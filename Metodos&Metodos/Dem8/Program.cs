using System.Xml;

namespace Dem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];
            int linha;
            int coluna;


            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    numeros[i, j] = rand.Next(1, 26);
                    //    do
                    //    {

                    //        Console.Write($"insira um número [{i + 1}, {j + 1}] : ");
                    //    } while(!int.TryParse(Console.ReadLine(), out numeros[i, j]));

                }

            }

            for (int i = 0; i < 5; i++)   // linhas
            {
                for (int j = 0; j < 5; j++) // colunas
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Qual linha da matriz gostaria de ver os valores: ");
            int.TryParse(Console.ReadLine(), out linha);

            Console.WriteLine("Qual coluna da matriz gostaria de ver os valores: ");
            int.TryParse(Console.ReadLine(), out coluna);


            Console.WriteLine(numeros[linha, coluna]);





            int somaColuna = 0;
            int somaLinha = 0;
            
            

            // Soma da coluna
            Console.Write("Qual coluna voce gostaria de ver a soma: ");
            int.TryParse(Console.ReadLine(), out coluna);
            coluna--;

            for (int i = 0; i < 5; i++)
            {
                somaColuna += numeros[i, coluna];
            }

            Console.WriteLine($"A coluna escolhida foi: {coluna + 1} e a soma é: {somaColuna}");


            // Soma da linha
            Console.Write("Qual linha voce gostaria de ver a soma: ");
            int.TryParse(Console.ReadLine(), out linha);
            linha--;

            for (int j = 0; j < 5; j++)
            {
                somaLinha += numeros[linha, j];
            }

            Console.WriteLine($"A linha escolhida foi: {linha + 1} e a soma é: {somaLinha}");

        }
    }
}