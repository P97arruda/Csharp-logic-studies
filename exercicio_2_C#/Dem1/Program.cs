namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true, B = true, C = false, D = false;

            Console.WriteLine(A || B || C || D);
            Console.WriteLine(A && B && C && D);
            Console.WriteLine(!C && !D);
            Console.WriteLine(!((A && B) || (B && !C)) || !(C && D));
            Console.WriteLine(!(!((A && !D) && (B || C))));
        }
    }
}
