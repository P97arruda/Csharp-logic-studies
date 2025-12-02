namespace Dem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int soma = 0;

            while(contador <= 5)
            {
                soma += contador;
                contador++;
            }

            Console.WriteLine($"Soma final {soma}");
        }
    }
}
