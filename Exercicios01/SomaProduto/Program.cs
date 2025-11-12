namespace SomaProduto
{
    internal class Program
    {
        /* 3. Create an application that determines and displays the sum and product of 3 values.*/
        static void Main(string[] args)
        {
            double n1, n2, n3, soma, produto;

            //Data entry
            Console.Write("Fast value: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second value: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("third value: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            //Processing
            
            soma = n1 + n2 + n3; 
            produto = n1 * n2 * n3;


            //data output 
            Console.WriteLine($"sum: {Math.Round(soma, 2)}");
            Console.WriteLine($"product: {Math.Round(soma, 2)}");


        }
    }
}
