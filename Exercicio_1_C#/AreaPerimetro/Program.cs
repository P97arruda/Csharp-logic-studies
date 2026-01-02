namespace AreaPerimetro
{
    internal class Program
    {
        /* 5. Create a programme that, based on the measurements of the sides of a rectangle (length and width) read from the keyboard,
         * calculates and prints the area and perimeter of the rectangle. The formula for the area of the rectangle is A = C * L and the
         * perimeter P = 2 * C + 2 * L. */
        static void Main(string[] args)
        {
            //Define variables
            double length, width, area, perimeter;

            //data input
            Console.Write("Rectangle length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rectangle width: ");
            width = Convert.ToDouble(Console.ReadLine());

            //Processing
            area = length * width;
            perimeter = 2 * length + 2 * width;
            
            //Data output
            Console.WriteLine($"Area: {Math.Round(area, 2)}");
            Console.WriteLine($"Perimter: {Math.Round(perimeter, 2)}");

        }
    }
}
