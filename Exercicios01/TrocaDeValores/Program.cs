namespace TrocaDeValores
{
    internal class Program
    {
        /* 13. Program to swap values between variable */
        
        static void Main(string[] args)
        {
            //Define variables
            int a, b, temp;

            //Data input
            Console.Write("Value of A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Value of B: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Processing 
            temp = a;
            a = b;
            b = temp;

            //Data output
            Console.WriteLine($"Value of A: {a} ");
            Console.WriteLine($"Value of B: {b} ");

        }
    }
}
