namespace NumeroPar
{
    internal class Program
    {
        // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);


            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}
