namespace Ex_12
{
    // Leia base e altura de um retângulo e calcule a área.
    // Ex.: 5 e 4 → 20


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Insira a altura: ");
            int.TryParse(Console.ReadLine(), out int altura);

            Console.Write("Insira a base: ");
            int.TryParse(Console.ReadLine(), out int baseRetangulo);

            int area = altura * baseRetangulo;

            Console.WriteLine($"A area do retangulo é: {area}");
        }
    }
}
