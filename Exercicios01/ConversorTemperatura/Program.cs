namespace ConversorTemperatura
{
    internal class Program
    {
        /* 12. Program to convert Fahrenheit to Celsius */
        
        static void Main(string[] args)
        {
            //Define variables
            double fahrenheit, celsius;

            //Data input
            Console.Write("Temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            //Processing
            celsius = (fahrenheit - 32) * 5 / 9;

            //Data output
            Console.WriteLine($"Temoerature in Celsius: {Math.Round(celsius, 2)}");
            
        }
    }
}
