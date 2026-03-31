using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Ex_3
{
    internal class Program
    {
        // Fazer um programa para ler os valores da largura e altura
        // de um retângulo.Em seguida, mostrar na tela o valor de
        // sua área, perímetro e diagonal.Usar uma classe como
        // mostrado no projeto ao lado

        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retâgulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area" + ret.Area());




        }
    }
}
