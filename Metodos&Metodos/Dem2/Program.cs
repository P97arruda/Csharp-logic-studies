using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dem2
{
    internal class Program
    {

        //2. Modifique o procedimento anterior, transformando-o numa função.

        static void Main(string[] args) 
        {
            int n1, n2;

            

            n1 = PedirNumero();
            


            
            Console.WriteLine($"Resultado: {MostrarRaizes(n1)}");
        }
       
        static int PedirNumero()
        {
            int numero;

            do
            {

                Console.Write("Insira um numero: ");

            }while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;

        }

        /// <summary>
        ///  Calcula a raiz quadrada do número recebido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Raiz quadrada do número </returns>
        static double MostrarRaizes(int numero)
        {
            
            return Math.Sqrt(numero);
        }
    }
}
