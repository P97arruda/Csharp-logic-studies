namespace Dem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NP, NC;
            int ponto = 1, casa;

            Console.Write("NP = ");
            int.TryParse(Console.ReadLine(), out NP);

            Console.Write("NC = ");
            int.TryParse((string)Console.ReadLine(), out NC);

            

            
            while (ponto <= NC)
            {
                casa = 1;
                while (casa <= NC)
                {
                    Console.WriteLine($"{ponto} - {casa}");
                    casa = casa + 1;
                }
                ponto = ponto + 1;
            }
        }
    }
}
