namespace TrianguloArea
{
    internal class Program
    {
        /* 6. Create an aplication that, when the user enters the base and heigtht values of a triangle, displays the area.
        */
        static void Main(string[] args)
        {
            //Define variables
            double baseTri, height, area;

            //Data input
            Console.Write("Triangle base: ");
            baseTri = Convert.ToDouble(Console.ReadLine());

            Console.Write("Trinagle height: ");
            height = Convert.ToDouble(Console.ReadLine());

            //Processing
            area = (baseTri *  height) / 2;

            //Data output
            Console.WriteLine($"Triangle area: {Math.Round(area, 2)}");


            
        }
    }
}
