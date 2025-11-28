namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero <= 20)
            {
                if (numero % 5 != 0)
                {
                    Console.WriteLine(numero);
                }
                 numero++;

            }
        }
            
    }
}
