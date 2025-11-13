namespace Dem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                Console.WriteLine("O número é Par");
            }
            else
            {
                Console.WriteLine("O número é IMPAR");
            }
        }
    }
}
