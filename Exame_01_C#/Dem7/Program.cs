using System.Drawing;

namespace Dem7
{
    internal class Program
    {
        // Elabore um programa que calcule o valor total de vendas de cada produto, subtraindo a respetiva
        // comissão e, sabendo que os dados estão guardados na seguinte matriz: (3 valores)

        static void Main(string[] args)
        {
           int[,] dados =
           {
            {1,  1,  1000, 10},
            {1, 12,   500, 15},

            {2,  1,   200,  0},
            {2,  2,   300,  0},
            {2,  3,   400,  0},
            {2,  4,   500,  0},

            {3, 10,  1000,  5},
            {3, 11,  2000, 10},
            {3, 12,  3000, 15}
           };

            double totalProduto1 = 0;
            double totalProduto2 = 0;
            double totalProduto3 = 0;

            for (int i = 0; i < 9; i++)
                {
                  int produto = dados[i, 0];
                  int valor = dados[i, 2];
                  int comissao = dados[i, 3];

                  double valorFinal = valor - (valor * comissao / 100.0);

                  if (produto == 1)
                      totalProduto1 += valorFinal;
                    else if (produto == 2)
                        totalProduto2 += valorFinal;
                    else
                        totalProduto3 += valorFinal;
                 }

                Console.WriteLine("Total Produto 1: " + totalProduto1);
                Console.WriteLine("Total Produto 2: " + totalProduto2);
                Console.WriteLine("Total Produto 3: " + totalProduto3);
            }
        }
}




