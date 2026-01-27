using System;

namespace Ex_2
{
    internal class Program
    {
        //. Leia números e some-os até que o usuário digite 0.

        static void Main(string[] args)
        {
            int numero = -1;
            int soma = 0;

            while (numero != 0)
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());
                
                if(numero != 0)
                {
                    soma += numero;
                }
            }

            Console.WriteLine($"A soma dos números digitados é: {soma}");

        }
    }
}
