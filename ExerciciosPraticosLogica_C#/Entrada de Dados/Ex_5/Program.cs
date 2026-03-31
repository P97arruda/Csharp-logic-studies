namespace Ex_5
{
    // 5. Leia dois números e exiba o maior
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out int numero1);

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);

            int numero = Math.Max(numero1, numero2);

            Console.WriteLine($"O maior numero é: {numero}");
        }
    }
}
