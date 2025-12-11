namespace Dem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NP, NC;
            


            Console.Write("NP = ");
            int.TryParse(Console.ReadLine(), out NP);

            Console.Write("NC = ");
            int.TryParse(Console.ReadLine(), out NC);

            for (int ponto = 1; ponto <= NP; ponto++)
            {
                for (int casa = 1; casa <= NC; casa++)
                {
                    Console.WriteLine($"{ponto} - {casa}");

                }
            }
        }
    }
}
