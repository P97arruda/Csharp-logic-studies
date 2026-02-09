namespace Dem4
{
    internal class Program
    {

        // Elabore um procedimento que receba dois parâmetros alfanuméricos e troque os seus valores

        static void Main(string[] args)
        {
            string valor1 = "";
            string valor2 = "";

            Recebervalores(ref valor1);
            Recebervalores(ref valor2);

            TrocarValores(ref valor1, ref valor2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        }

        /// <summary>
        /// Lê um valor introduzido pelo utilizador.
        /// </summary>
        /// <param name="valor"></param>
        static void Recebervalores(ref string valor)
        {
            Console.Write("Insira um valor alfanumérico: ");
            valor = Console.ReadLine();

        }

        /// <summary>
        /// Troca os valores.
        /// </summary>
        /// <param name="valor1"> Primeiro valor. </param>
        /// <param name="valor2"> Segundo valor. </param>
       
        static void TrocarValores(ref string valor1, ref string valor2) 
        {
            string aux;

            aux = valor2;
            valor2 = valor1;
            valor1 = aux;
        }
    }
}
