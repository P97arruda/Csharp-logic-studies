using System.Runtime.ConstrainedExecution;

namespace NumeroPositivo
{
    internal class Program
    {
        // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero >= 0) 
            {
                Console.WriteLine("NÃO É NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

        }
    }
}
