namespace Ex_6
{
    internal class Program
    {
        // Mostre os números pares de 1 a 100 usando while.
        static void Main(string[] args)
        {
            int numero1 = 1;
            

            while(numero1 <= 100 )
            {
                if ( numero1 % 2 == 0)
                {
                    Console.WriteLine(numero1);
                }
                numero1++;
            }
        }
    }
}
