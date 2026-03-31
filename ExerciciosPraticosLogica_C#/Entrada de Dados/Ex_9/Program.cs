namespace Ex_9
{
   // 9. Leia o preço e a quantidade de um produto e calcule o total.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insira a o preço do produto: ");
            double.TryParse(Console.ReadLine(), out double preco);

            Console.Write("insira a quantidade comprada: ");
            int.TryParse(Console.ReadLine(), out int quantidade);

             double total = preco * quantidade;

            Console.WriteLine($"O valor total da compra é: {total}");
        }
    }
}
