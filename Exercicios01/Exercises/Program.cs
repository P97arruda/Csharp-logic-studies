namespace Exercises
{
    internal class Program
    {
        /* 2. Create a programme that receives a value in euros and convert it into dollars. Use taday´s exchange rate .*/
        static void Main(string[] args)
        {
            double euros, dollars;

            Console.Write("enter the value: ");
            euros = Convert.ToDouble(Console.ReadLine());

            dollars = euros * 1.08;

            Console.WriteLine($"{euros} euros = {Math.Round(dollars, 2)} dollars");
        }   
    }
}
