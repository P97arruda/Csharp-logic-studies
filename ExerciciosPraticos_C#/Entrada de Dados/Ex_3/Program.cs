namespace Ex_3
{
    // 3. Leia dois números e exiba a média.
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.Write("Insira um numero: ");
            double.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira outro numero: ");
            double.TryParse(Console.ReadLine(), out numero2);

            numero1 = (numero1 + numero2) / 2;

            Console.WriteLine($"A média dos numero é: {Math.Round(numero1,2)}");
        }
    }
}
