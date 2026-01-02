namespace AreaRetangular
{
    internal class Program
    {
        /* 9. A rectangular wall, whose height is hp (wall height) and width is lp (wall width) ,
            needs to be covered with rectangular tiles. The rectangular tile has 
            dimensions ha (tile height) and la (tile width). 
            Write a programme that reads the four measurements hp, lp, ha, and la, calculates and prints how many 
            tiles with the given measurements are needed to cover the given wall.  */
        
        static void Main(string[] args)
        {
         // Define variables
         double hp, lp, ha, la, areaParede, areaAjulejo, azulejos;

            //Data input
            Console.Write("Wall heigth (hp): ");
            hp = Convert.ToDouble(Console.ReadLine());

            Console.Write("wall width (lp): ");
            lp = Convert.ToDouble(Console.ReadLine());

            Console.Write("wall width (ha): ");
            ha = Convert.ToDouble(Console.ReadLine());

            Console.Write("wall width (la): ");
            la = Convert.ToDouble(Console.ReadLine());

            //Processing
            areaParede = hp * lp;
            areaAjulejo = ha * la;
            azulejos = areaParede / areaAjulejo;

            Console.WriteLine($"Azulejos nescessario: {azulejos}");

        }
    }
}
