namespace Ex_7
{
    // 7. Leia três números e exiba a soma deles.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

            Console.Write("Insira mais um numero: ");
            int.TryParse(Console.ReadLine(), out numero3);

            int soma = numero1 + numero2 + numero3;
            Console.WriteLine($"A soma dos numero é: {soma}");
        }
    }
}
