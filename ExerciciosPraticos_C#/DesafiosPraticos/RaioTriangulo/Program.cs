using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RaioTriangulo
{
    internal class Program
    {
        // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        // casas decimais conforme exemplos.
        // Fórmula da área: area = π.raio2
        // Considere o valor de π = 3.14159

        static void Main(string[] args)
        {
            double raio; 

            Console.Write(" ");
            double.TryParse(Console.ReadLine(), out raio);



            Console.WriteLine($"A = {raio}");

        }
    }
}
