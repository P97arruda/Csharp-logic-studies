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
            n2 = PedirNumero();

            //TrocaValor(n1, n2);

            MostrarRaizes(n1, n2);


        }


        
        static int PedirNumero()
        {
            int numero;

            do
            {

                Console.Write("Insira o numero: ");

            } while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }



        //static int TrocaValor(int n1, int n2)
        //{
        //    int troca;

        //    if (n1 < n2)
        //    {
        //        troca = n1;
        //       n1 = n2;
        //       n2 = troca;
        //    }
        //    return (n1, n2);
        //}



        static void MostrarRaizes(int Inf, int Sup)
        {

            while (Inf <= Sup)
            {
                double raiz = Math.Sqrt(Inf);
                Console.WriteLine($"Raiz de {Inf} = {Math.Round(raiz, 2)}");
                Inf++;


            }


        }

    }
}
