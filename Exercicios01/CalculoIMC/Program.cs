using System.Diagnostics.Metrics;

namespace CalculoIMC
{
    internal class Program
    {
        /* 4. A person's physical condition can be measured based on the calculation of their Body Mass Index 
        (BMI). This is calculated by dividing the person's weight by the square of their height 
        in metres.Write a programme that reads a person's weight in kilograms and height in metres, 
        calculates their BMI and displays it.*/
        
        static void Main(string[] args)
        {
            double weight, height, bmi;

            //Data input
            Console.Write("Enter weight (kg): ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (m): ");
            height = Convert.ToDouble(Console.ReadLine());

            //Processing
            bmi = weight / (height * height);

            //Data output
            Console.WriteLine($"Your BMI is: {Math.Round(bmi, 2)}");
        }
    }
}
