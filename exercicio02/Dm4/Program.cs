using System.ComponentModel.Design;

namespace Dm4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.Write("Insira a nota? ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 0 && nota <= 20)
            {
                if (nota <= 4)
                {
                    Console.WriteLine("A nota foi bem Mau");
                }
                else if (nota <= 9)
                {
                    Console.WriteLine("A Nota foi Boa!");
                }
                else if (nota <= 14)
                {
                    Console.WriteLine("A nota foi Muito Boa");
                }
                else if (nota <= 17)
                {
                    Console.WriteLine("Parabens Pela Nota!!!");
                }
                else
                {
                    Console.WriteLine("Parabens pela grande nota!!!");
                }
            }
            else
            {
                Console.WriteLine("Não é uma nota válida.");
            }
                

      
               

            
        }
    }
}
