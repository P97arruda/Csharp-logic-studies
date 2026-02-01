using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace EstruturaSequencial
{
    internal class Program
    {
        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
        // Entrada: 12 1 5. 30                  Saida: Valor a pagar: R$ 15.50
        //          16 2 5. 10           

        static void Main(string[] args)
        {
            int quantidade1, quantidade2, codigo1, codigo2;
            double valorPagar, valor1 = 5.30, valor2 = 5.10;

            Console.Write("insira o codigo: ");
            int.TryParse(Console.ReadLine(), out codigo1);

            Console.Write("insira o numero de perças: ");
            int.TryParse(Console.ReadLine(), out quantidade1);

            Console.Write("insira o codigo: ");
            int.TryParse(Console.ReadLine(), out codigo2);

            Console.Write("insira o numero de perças: ");
            int.TryParse(Console.ReadLine(), out quantidade2);



            valorPagar = quantidade1 * valor1 + quantidade2 * valor2;

            Console.WriteLine($" O VALOR A PAGAR: {valorPagar}");










        }
    }
}
