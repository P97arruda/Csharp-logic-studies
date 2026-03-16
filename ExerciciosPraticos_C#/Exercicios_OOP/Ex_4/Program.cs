using System.Numerics;

namespace Ex_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta dividas = new Conta();

            Console.WriteLine("Digite seu salario: ");
            dividas._salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite renda da casa: ");
            dividas._rendaCasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite parcela do carro: ");
            dividas._salario = int.Parse(Console.ReadLine());

            int resultado = dividas.SomaGatos();

            Console.WriteLine("Dinheiro restante: " + resultado);
        }
    }
}
