namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[10, 10];

            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    do
                    {

                        Console.Write($"insira um número [{i + 1}, {j + 1}] : ");
                    } while(!int.TryParse(Console.ReadLine(), out numeros[i, j]));

                }  
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine();
            }





        }

    }
}
