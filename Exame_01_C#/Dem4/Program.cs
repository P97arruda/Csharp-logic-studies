using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dem4
{
    internal class Program
    {
        //Elabore um programa que calcule o valor de A mediante a entrada de um N inteiro positivo.
         
        


        static void Main(string[] args)
        {
            int N = 0;
            double A = 0;
            double denominador = 1;

            Console.Write("Digite um numero inteiro positivo: ");

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Valor invalido. Deve ser um numero inteiro.");
            }
            else if (N <= 0)
            {
                Console.WriteLine("Valor invalido. Deve ser positivo.");
            }
            else
            {
                for (int numerador = N; numerador >= 1; numerador--)
                {
                    A = A + numerador / denominador;
                    denominador++;
                }

                Console.WriteLine("Resultado de A: " + A);
            }




        }
    }
}
