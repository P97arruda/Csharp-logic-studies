namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;


            Console.WriteLine("Insira um numero entre 1 e 10: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i < 10; i++)
            {

                resultado = numero * i;
                Console.WriteLine($"{numero} * {i} = {resultado}");

            }

        }
    }
}