using System.Threading.Channels;

namespace Dem3
{
    internal class Program
    {
        // Elabore um procedimento que escreva os primeiros X nomes de um array.O procedimento tem
        // como parâmetros de entrada a lista de nomes e o número de elementos a selecionar.
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
           int X = 0;

            PreencherTabela(nomes);

            MostarNomes(X);

           // Console.WriteLine($"{nomes[X]}");

        }

        static void PreencherTabela(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
        }

        static void MostarNomes(int X) 
        {
            //int X;
            
            do
            {

                Console.WriteLine("Indique até que posição da tabela pretende visualizar os nomes:");

            } while (!int.TryParse(Console.ReadLine(), out X));


            for (int i = 0; i < X; i++) 
            {
                Console.WriteLine($"{X}");
            }
        
        }

    

    }
}
