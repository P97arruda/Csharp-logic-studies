using System.IO.Pipes;

namespace Ex_8
{
    //8. Leia a idade e ano de nascimento e calcule a idade correta.

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.Write("Insira seu ano de nascimento: ");
            int.TryParse(Console.ReadLine(), out int AnoDeNascimento);

            int idade = 2026 - AnoDeNascimento;

            Console.WriteLine($"Sua idade correta é: {idade}");
        }
    }
}
