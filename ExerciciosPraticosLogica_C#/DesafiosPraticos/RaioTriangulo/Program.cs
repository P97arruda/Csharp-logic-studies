using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Globalization;
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
            double area;
            double raio;
            double PI = 3.14159;

            Console.Write("Insira o valor do raio: ");
            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out raio);

            area = PI * raio * raio;

            Console.WriteLine($"Area = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
