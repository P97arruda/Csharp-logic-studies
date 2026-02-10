using System.Net;
using System.Net.Http.Headers;

namespace Dem1
{
    internal class Program
    {
        //Elabore um procedimento que mostre as raízes quadradas dos inteiros de um dado intervalo.
        //O programa principal deverá invocar este procedimento para mostrar as raízes quadradas dos
        //números inteiros compreendidos no intervalo dado pelo utilizador.

        // Parâmetro           Tipo      Significado
        // Inf                 int       Limite   inferior do intervalo
        // Sup                 int       Limite   superior do intervalo

        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;

            //n1 = PedirNumero();
            //n2 = PedirNumero();

            PedirNumeroPorReferencia(ref n1);
            PedirNumeroPorReferencia(ref n2);

            //TrocaValor(ref n1, ref n2);

            //Console.WriteLine();

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            //*onsole.WriteLine();

            MostrarRaizes(n1, n2);

        }

        static void PedirNumeroPorReferencia(ref int numero)
        {
            //int numero;

            do
            {

                Console.Write("Insira o numero: ");

            } while (!int.TryParse(Console.ReadLine(), out numero));
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="Inf"></param>
       /// <param name="Sup"></param>
        static void  MostrarRaizes( int Inf, int Sup)
        {

            while (Inf <= Sup) 
            {
                double raiz = Math.Sqrt(Inf);
                Console.WriteLine($"Raiz de {Inf} = {Math.Round(raiz,2)}");
                Inf++;

                
            }
            

        }



        //static void TrocaValor(ref int n1, ref int n2)
        //{
        //    int troca;

        //    if (n1 > n2)
        //    {
        //        troca = n1;
        //        n1 = n2;
        //        n2 = troca;
        //    }
        //}
    }


}
