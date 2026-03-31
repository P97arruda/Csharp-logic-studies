using System.Globalization;

namespace Ex_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

          Class1 p1 = new Class1();
          Class1 p2 = new Class1();



            Console.WriteLine("insira os dados da primeira pessoa");

            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome da segunda pessoa");

            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade >= p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais vela {p2.Nome}");
            }


        }
    }
}
