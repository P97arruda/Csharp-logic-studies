using System.Net;

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
            int n1, n2;

            //n1 = PedirNumero();
            //n2 = PedirNumero();

            
        }

        static void PedirNumero()
        {
            int numero;

            do
            {

                Console.Write("Insira o numero: ");

            } while (!int.TryParse(Console.ReadLine(), out numero));
        }


        static void TrocaValor;




        static void  MostrarRaizes(int Int, int Sup)
        {
            

        }
    }


}
