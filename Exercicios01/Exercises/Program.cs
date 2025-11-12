namespace Exercises
{
    internal class Program
    {
        /* 2. Crie um programa que receba um valor em euros e converta-o a dólares. Use o cambio do dia hoje.*/
        static void Main(string[] args)
        {
            double euros, dolares;

            Console.Write("Insira o valor em euros: ");
            euros = Convert.ToDouble(Console.ReadLine());

            dolares = euros * 1.08;

            Console.WriteLine($"{euros} euros = {Math.Round(dolares, 2)} dólares");
        }   
    }
}
