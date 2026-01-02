namespace Ex_2
{
      // 2. Leia dois números e exiba a soma.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero1);  

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

            numero1 = numero1 + numero2;

            Console.WriteLine($"A soma dos numero é: {numero1}");
        }
    }
}
