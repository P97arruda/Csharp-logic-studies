namespace Ex_6
{
    // 6. Leia dois números e exiba o menor.


    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out int numero1);

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);

            int numero = Math.Min(numero1, numero2);

            Console.WriteLine($"O menor numero é: {numero}");
        }
    }
}
