using System.Drawing;

namespace RaioDeCirculo
{
    internal class Program
    {
       // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
       // casas decimais conforme exemplos.
       //Considere o valor de π = 3.1415
        
        static void Main(string[] args)
        {
            double area, raio;

            Console.Write("Insira o Raio: ");
            double.TryParse(Console.ReadLine(), out raio);


            area = Math.PI * raio * raio;

            Console.WriteLine($" A = {Math.Round(area, 2)}");


        }
    }
}
