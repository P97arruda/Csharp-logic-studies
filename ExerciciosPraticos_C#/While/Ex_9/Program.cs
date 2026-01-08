namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int numero;
            int resultado;

            Console.Write("insira um número para ver sua tabuada: ");
            int.TryParse(Console.ReadLine(), out numero);

            while (i <= 10)
            {
                resultado = numero * i;

                if(resultado % 2 == 0)
                {
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }
                i++;
            }
        }

    }
}
