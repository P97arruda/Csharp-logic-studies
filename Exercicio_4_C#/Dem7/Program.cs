using System.ComponentModel.Design;
using System.Xml.Schema;

namespace Dem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numero1, numero2, resultado = 0;

            Console.Write("Insira o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira o segundo numero: ");
            int.TryParse(Console.ReadLine(), out numero2);


            while (numero1 <= numero2) 
            {
                if(numero1 % 2 == 0)
                {
                    resultado = resultado + numero1;
                }
                numero1++;
            }
            Console.WriteLine($"A soma dos numeros pares e: {resultado}");
        }
    }
}
