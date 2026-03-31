namespace SomaDoisNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            Console.Write("Insira primeiro numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("insira o segundo numero: ");
            int.TryParse(Console.ReadLine() , out numero2);

            resultado = numero1 + numero2;

            Console.WriteLine($"{resultado}");

        }
    }
}
