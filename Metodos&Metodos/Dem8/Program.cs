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

            Console.WriteLine("Qual linha da matriz gostaria de ver os valores: ");
            int.TryParse(Console.ReadLine(), out linha);

            Console.WriteLine("Qual coluna da matriz gostaria de ver os valores: ");
            int.TryParse(Console.ReadLine(), out coluna);


            for (int i = 0; i <= linha; i++)   // linhas
            {
                for (int j = 0; j <= coluna; j++) // colunas
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
