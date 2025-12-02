namespace Dem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            Console.WriteLine($"Categoria {(idade < 18 ? "Menor" : (idade <= 64 ? "Adulto" : "Senior"))}");
        }
    }
}
