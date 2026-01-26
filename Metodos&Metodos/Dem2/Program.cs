using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dem2
{
    internal class Program
    {

        //2. Modifique o procedimento anterior, transformando-o numa função.
        
        static void Main(string[] args)
        {

            Console.WriteLine($"");

        }

        static void PedirNumero()
        {
            int numero;

            do
            {

                Console.Write("Insira o numero: ");

            } while (!int.TryParse(Console.ReadLine(), out numero));
        }

        static int MostrarRaizes(int Int, int Sup)
        {
            return Math.Sqrt();
        }

    }
}
