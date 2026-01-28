using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dem2
{
    internal class Program
    {

        //2. Modifique o procedimento anterior, transformando-o numa função.

        static void Main(string[] args) 
        {
            int n1, n2;

            //double resultado;

            n1 = PedirNumero();
            n2 = PedirNumero();


            //resultado = MostrarRaizes(n1, n2);
            Console.WriteLine($"Resultado: {MostrarRaizes(n1,n2)}");

            //MostrarRaizes(n1, n2);
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
        
        static double MostrarRaizes(int Inf, int Sup)
        {
            double raiz = 0;

           
                while (Inf <= Sup)
                {
                    raiz = Math.Sqrt(Inf);
                    Inf++;
                }
            return raiz;
        }
    }
}
