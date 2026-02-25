using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Multiplos
{
    internal class Program
    {
        // Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        // ordem crescente ou decrescente
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Ensira um numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Ensira outro numero: ");
            int.TryParse(Console.ReadLine(), out numero2);


            if (numero1 % numero2 == 0)
            {
                Console.WriteLine("São multilos");
            }
            else if (numero2 % numero1 == 0) 
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

        }
    }
}
