namespace ExepressoesMath
{
    internal class Program
    {
        /* 7. Create a application that obtains the values of a, b, c, and d, then give the results of the following expressions. */
        static void Main(string[] args)
        {
            double a, b, c, d, result1, result2, result3, result4;

            //Data input
            Console.Write("Value of a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Value of c: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Value of d: ");
            d = Convert.ToDouble(Console.ReadLine());

            //Processing
            result1 = 2 * b;
            result2 = 3 * c * c * (9 - 5);
            result3 = 2 * c + b * b;
            result4 = 3 * d + 3 * c * (25 + 6);

            //Data output
            Console.WriteLine($"1. 2b = {Math.Round(result1, 2)}");
            Console.WriteLine($"2.3c (9-5) = {Math.Round(result2, 2)}");
            Console.WriteLine($"3.2c + b2 ={Math.Round(result3, 2)}");
            Console.WriteLine($"4. 3d + 3ac(25+6) = {Math.Round(result4, 2)}");


        }
    }
}
