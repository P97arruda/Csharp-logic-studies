using System.Xml;

namespace Dem7
{
    internal class Program
    {
        //  Elabore um programa que tenha os seguintes procedimentos e funções:
        //  Procedimento: Escreve valores numa matriz
        //  Procedimento: Mostra os valores de uma matriz mediante coordenadas dadas
        //  Função: Calcula o somatório das linhas/colunas indicadas
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];
            int linha, coluna;
            int somaLinha, somaColuna, total;

            InserirValores(numeros);
            MostrarValores(numeros);


            Console.Write("Qual linha voce gostaria de ver: ");
            int.TryParse(Console.ReadLine(), out linha);

            Console.Write("Qual coluna voce gostaria de ver: ");
            int.TryParse(Console.ReadLine(), out coluna);

            

            MostrarValoresCoordenadas(numeros, linha, coluna);

            Console.Write("Qual linha quer somar (0 a 4): ");
            int.TryParse(Console.ReadLine(), out somaLinha);
           

            Console.Write("Qual coluna quer somar (0 a 4): ");
            int.TryParse(Console.ReadLine(), out somaColuna);
           

            total = SomarValoresCordenadas(numeros, somaLinha, somaColuna);

            Console.WriteLine(total);


        }


        /// <summary>
        /// Preenche a matriz com valores aleatórios
        /// </summary>
        /// <param name="numeros">Matriz de inteiros.</param>
        static void InserirValores(int[,] numeros ) 
        {
            Random rand = new Random();

            for (int i = 0; i < 5; i++) 
            { 
                for (int j = 0; j < 5; j++)
                {
                    numeros[i, j] = rand.Next(1, 26);
                }
            }
        }

        /// <summary>
        /// Mostra todos os valores da matriz.
        /// </summary>
        /// <param name="numeros">Matriz de inteiros</param>
        static void MostrarValores(int[,] numeros)
        {
            for (int i = 0; i < 5; i++)
            {
               for (int j = 0; j < 5; j++)
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
        }

        /// <summary>
        /// Mostra os valores da linha e da coluna indicadas.
        /// </summary>
        /// <param name="numeros">Matriz de inteiros.</param>
        /// <param name="linha">Linha a mostrar.</param>
        /// <param name="coluna">Coluna a mostrar.</param>
        static void MostrarValoresCoordenadas(int[,] numeros, int linha, int coluna) 
         {

            Console.WriteLine(numeros[linha, coluna]);

        }


        /// <summary>
        /// Calcula o somatório da linha e da coluna indicadas.
        /// </summary>
        /// <param name="numeros">Matriz de inteiros.</param>
        /// <param name="somalinha">>Linha a somar.</param>
        /// <param name="somacoluna">>Coluna a somar.</param>
        /// <returns>Somatório da linha/coluna indicada.</returns>
        static int SomarValoresCordenadas(int[,] numeros, int somalinha, int somacoluna)
        {
            int total = 0;

            for (int j = 0; j < 5; j++)
            {
                total += numeros[somalinha, j];
            }

            for(int i = 0; i < 5; i++)
            {
                total += numeros[i, somacoluna];
            }

              total -= numeros[somalinha, somacoluna];


            return total;
        }
    }
}
