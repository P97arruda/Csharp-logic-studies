using System.Runtime.InteropServices;

namespace CalculoNotas
{
    internal class Program
    {   
        /* 8. Create a programme to calculate the final averege of 4 marks. The average is calculated using
         * a simple aithmetic mean (all marks have the same weight). */
        static void Main(string[] args)
        {
            //Define variabels
            double grade1, grade2, grade3, grade4, average;

            //Data input
            Console.Write("Grade 1: ");
            grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 2: ");
            grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 3: ");
            grade3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 4");
            grade4 = Convert.ToDouble(Console.ReadLine());

            average = (grade1 + grade2 + grade3 + grade4) / 4;

            Console.WriteLine($"Final average: {Math.Round(average, 2)}");
            
        }
    }
}
