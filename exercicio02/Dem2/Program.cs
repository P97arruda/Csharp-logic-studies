namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ensira o numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($" {num} é Positivo!");
            }
            else if (num < 0) 
            {
                Console.WriteLine($" {num} é negativo!");
            }
            else
            {
                Console.WriteLine($" {num} é neutro!");
            }
        }
    }
}
