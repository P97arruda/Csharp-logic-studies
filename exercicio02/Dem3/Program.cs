namespace Dem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Escreva o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) {
                Console.WriteLine($"O Primeiro numero é o maior! {num1} ");
            }
            else
            {
                Console.WriteLine($"O segundo numero é o maior! {num2} ");
            }


        }
    }
}
