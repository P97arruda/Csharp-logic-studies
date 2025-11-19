namespace Dem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que mediante a entrada de uma nota entre 0 e 20 valores indique a 
               respetiva classificação qualitativa usando a seguinte tabela
                Entre 0 e 5  Fraco
                Entre 6 e 9  insuficinte
                Entre 10 e 14 Satifaz
                Entre 15 e 18 Bom
                Entre 19 e 20 Muito BoM */

            double nota;

            Console.WriteLine("Insira a nota : ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 0 && nota <= 20) 
            {
                if (nota <= 5)
                {
                    Console.WriteLine("O teste foi Fraco");
                }
                else if (nota <= 9)
                {
                    Console.WriteLine("O teste foi insuficiente");
                }
                else if (nota <= 14)
                {
                    Console.WriteLine("O teste foi Satisfas");
                }
                else if (nota <= 18)
                {
                    Console.WriteLine("O teste foi Bom");
                }
                else
                {
                    Console.WriteLine("O teste foi Muito Bom");
                }
            }
            else
            {
                Console.WriteLine("A nota não é valida");
            }
        }
    }
}
