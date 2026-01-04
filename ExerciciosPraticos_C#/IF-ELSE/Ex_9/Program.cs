namespace Ex_9
{
    internal class Program
    {
        // Leia um número inteiro e informe se está entre 0 e 100.
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero >= 0 && numero <= 100)
            {
                Console.WriteLine("O numero esta entre 0 e 100.");
            }
            else             
            {
                Console.WriteLine("O numero não esta entre 0 e 100.");
            }
        }
    }
}
