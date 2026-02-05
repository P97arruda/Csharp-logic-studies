using System.Runtime.ConstrainedExecution;

namespace Dem6
{
    internal class Program
    {
         // Elabore um programa que conte o número de ocorrências de cores num array genérico.
         // O programa deverá primeiro pedir para ser preenchido o array, por uma cor do tipo
         // Cores. Considere o tipo Cores { Vermelho, Azul, Amarelo, Verde, Branco}
        //  (3 valores)

        enum Cores { Vermelho, Azul, Amarelo, Verde, Branco}
        static void Main(string[] args)
        {
            {
                Cores[] cores = new Cores[3];

                int vermelho = 0;
                int azul = 0;
                int amarelo = 0;
                int verde = 0;
                int branco = 0;

                
                for (int i = 0; i < cores.Length; i++)
                {
                    Console.WriteLine("Digite uma cor (Vermelho, Azul, Amarelo, Verde, Branco):");
                    Enum.TryParse(Console.ReadLine(), out cores[i]);
                }

                
                for (int i = 0; i < cores.Length; i++)
                {
                    if (cores[i] == Cores.Vermelho)
                    {
                        vermelho++;
                    }
                    else if (cores[i] == Cores.Azul)
                    {
                        azul++;
                    }
                    else if (cores[i] == Cores.Amarelo)
                    {
                        amarelo++;
                    }
                    else if (cores[i] == Cores.Verde)
                    {
                        verde++;
                    }
                    else if (cores[i] == Cores.Branco)
                    {
                        branco++;
                    }
                }

                Console.WriteLine("Vermelho: " + vermelho);
                Console.WriteLine("Azul: " + azul);
                Console.WriteLine("Amarelo: " + amarelo);
                Console.WriteLine("Verde: " + verde);
                Console.WriteLine("Branco: " + branco);
            }
        }
    }
}
