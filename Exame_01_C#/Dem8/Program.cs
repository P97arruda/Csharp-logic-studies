using System.Runtime.Intrinsics.X86;

namespace Dem8
{
    internal class Program
    {
        //Elabore um programa que calcule o determinante de uma matriz de inteiros inseridos
        //aleatoriamente, de terceira ordem pela regra de Sarrus. (3 valores

        static void Main(string[] args)
        {

            int somaPrincipal;
            int somaSecundaria;
            int determinante;

            int[,] matriz =
            {
            {1, 2, 3},
            {3, 1, 4},
            {0, 1, 2}
            };

            

            somaPrincipal =
                matriz[0, 0] * matriz[1, 1] * matriz[2, 2] +
                matriz[0, 1] * matriz[1, 2] * matriz[2, 0] +
                matriz[0, 2] * matriz[1, 0] * matriz[2, 1];

            somaSecundaria =
                matriz[0, 2] * matriz[1, 1] * matriz[2, 0] +
                matriz[0, 0] * matriz[1, 2] * matriz[2, 1] +
                matriz[0, 1] * matriz[1, 0] * matriz[2, 2];

            determinante = somaPrincipal - somaSecundaria;

            Console.WriteLine("Determinante = " + determinante);
        }
    }
}

