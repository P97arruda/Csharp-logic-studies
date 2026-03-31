namespace Ex_1
{
    // 1. Leia um número inteiro e exiba seu valor

    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"O numero inserido foi {numero}");

        }
    }
}
