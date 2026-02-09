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

           

            Console.WriteLine("Informe a quantidade de nomes que deseja ver: ");
            int.TryParse(Console.ReadLine(), out X);

            MostarNomes(nomes, X);

        }
        /// <summary>
        /// Preenche um array de nomes com valores introduzidos pelo utilizador.
        /// </summary>
        /// <param name="nomes"></param>
        static void PreencherTabela(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
        }

        /// <summary>
        /// Escreve os primeiros X nomes de um array.
        /// </summary>
        /// <param name="nomes"> Array que contém os nomes a serem apresentados. </param>
        /// <param name="X"> Quantidade de nomes a apresentar a partir do início do array. </param>
        static void MostarNomes(string[] nomes, int X) 
        {
          

            for (int i = 0; i < X; i++) 
            {
                Console.WriteLine(nomes[i]);
            }
        
        }

    

    }
}
