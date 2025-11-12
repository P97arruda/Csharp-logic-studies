namespace VolumeRaioAltura
{
    internal class Program
    {
        /* 11. Write a programme that calculates and displays the volume of a can of oil using the 
          formula: V = 3.14159 * R * R * A, where the variables V, R and A represent the 
          volume, radius and height, respectively.  */
        
        static void Main(string[] args)
        {
            double radius, height, volume;

            Console.Write("Can Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cam height: " );
            height = Convert.ToDouble(Console.ReadLine());

            //Processing
            volume = 3.14159 * radius * radius * height;

            Console.WriteLine($"Cam volume: {Math.Round(volume, 2)}");
            
        }
    }
}
