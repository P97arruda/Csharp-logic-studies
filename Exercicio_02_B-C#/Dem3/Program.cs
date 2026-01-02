using System.ComponentModel.Design;

namespace Dem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoIdeal;
            char sexo;
            
            Console.Write("Introduza a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduza o sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());

            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Peso ideal: {Math.Round(pesoIdeal, 2)} kg");
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Peso ideal: {Math.Round(pesoIdeal, 2)} kg");
            }
            else 
            {
                Console.WriteLine("Sexo invalido!");
            }
        }
    }
}
