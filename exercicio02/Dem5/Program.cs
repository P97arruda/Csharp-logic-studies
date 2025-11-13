using System.ComponentModel.Design;

namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Insita o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insita o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insita o terceiro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                  Console.WriteLine($"O menor némero é: {num1}");
                }
                else
                {
                  Console.WriteLine($"O menor número é: {num3}");
                }

            }
            else
            {
                if ( num2 < num3)
                {
                  Console.WriteLine($"O menor numero é {num2}");
                }
                else
                {
                    Console.WriteLine($"O menor numero é {num3}");
                }
            }
            
        }
    }
}