using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace ExercicioValorPeças
{
    internal class Program
    {
       // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
       // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

        static void Main(string[] args)
        {
           int codigo1, codigo2, numeroPecas1, numeroPecas2;
           double valorPreca1, valorPreca2, resultado;


            Console.Write("Insira o primeiro codigo: ");
            int.TryParse(Console.ReadLine(), out codigo1);

            Console.Write("Insira o numero de peças: ");
            int.TryParse(Console.ReadLine(), out  numeroPecas1);

            Console.Write("Insira o valor unitario das peças: ");
            double.TryParse(Console.ReadLine(), out valorPreca1);

            Console.WriteLine();

            Console.Write("Insira o primeiro codigo: ");
            int.TryParse(Console.ReadLine(), out codigo2);

            Console.Write("Insira o numero de peças: ");
            int.TryParse(Console.ReadLine(), out numeroPecas2);

            Console.Write("Insira o valor unitario das peças: ");
            double.TryParse(Console.ReadLine(), out valorPreca2);

            resultado = numeroPecas1 * valorPreca1 + numeroPecas2 * valorPreca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {resultado:f2}");
        }
    }
}
