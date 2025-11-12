namespace ImpostoTerreno
{
    internal class Program
    {
        // 10. Program to calculate property tax
        static void Main(string[] args)
        {
            //Define input
            double totalArea, builArea, unbuilArea, tax;

            //Data input
            Console.Write("Total land area (m2) ");
            totalArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Built area (m2): ");
            builArea = Convert.ToDouble(Console.ReadLine());

            //Processing 
            unbuilArea = totalArea - builArea;
            tax = (unbuilArea * 50.00) + (unbuilArea * 5.80);

            //Data output
            Console.WriteLine($"Total tax: {Math.Round(tax, 2)}");

            
        }
    }
}
