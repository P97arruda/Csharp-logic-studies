namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, N = 1;

            Console.Write("Insira um numero entre 1 e 10: ");
            int.TryParse(Console.ReadLine(), out numero);

            while(N <= 10)
            {
                resultado = numero * N;
                Console.WriteLine($"{numero} * {N} = {resultado}");
                N++;
            }
        }
    }
}
