using System.Runtime.ConstrainedExecution;

namespace SomaProduto
{
    internal class Program
    {
        // Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
        // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A* B - C* D).

        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, total;

            Console.Write("Insira um valor: ");
            int.TryParse(Console.ReadLine(), out valor1);

            Console.Write("Insira um valor: ");
            int.TryParse(Console.ReadLine(), out valor2);

            Console.Write("Insira um valor: ");
            int.TryParse(Console.ReadLine(), out valor3);

            Console.Write("Insira um valor: ");
            int.TryParse(Console.ReadLine(), out valor4);

            total = valor1 * valor2 - valor3 * valor4;

            Console.WriteLine($"DIFERENÇA {total}");
        }
    }
}
