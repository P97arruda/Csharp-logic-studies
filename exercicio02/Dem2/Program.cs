namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ensira o numero inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($" {numero} é Positivo!");
            }
            else if (numero < 0) 
            {
                Console.WriteLine($" {numero} é negativo!");
            }
            else
            {
                Console.WriteLine($" {numero} é neutro!");
            }
        }
    }
}
