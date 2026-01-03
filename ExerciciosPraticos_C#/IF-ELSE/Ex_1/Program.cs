namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; 

            Console.WriteLine("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"O numero inserido foi: {numero}");



        }
    }
}
