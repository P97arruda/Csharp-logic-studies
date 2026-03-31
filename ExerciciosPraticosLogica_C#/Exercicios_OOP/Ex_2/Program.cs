using Ex_;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            Class1 p2 = new Class1();

            Console.WriteLine("Insira o nome da primeira pessoa");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Insira o salario da primeira pessoa");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o nome da segunda pessoa");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Insira o salario da segunda pessoa");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine($"Salario medio = { salarioMedio:F2}");
        }
    }
}
