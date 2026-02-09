using System;
using System.Diagnostics;
using System.Globalization;

namespace Dem5
{
    internal class Program
    {
        // Elabore uma função que retorne quantos nomes inseridos num array enviado como parâmetro
        // começam por A, B ou C
        static void Main(string[] args)
        {
            string[] nome = new string[] { "Maria", "Ana", "Julia", "Carla", "Ana Julia" };




            int resultado = ContarIniciais(nome);

            Console.WriteLine($" Total de nomes com iniciais A, B ou C: {resultado}");
            
        }


        /// <summary>
        /// Conta nomes com inicial A, B ou C.
        /// </summary>
        /// <param name="nomes">Array de strings.</param>
        /// <returns>Array de contadores.</returns>
        static int ContarIniciais(string[] nomes)
        {
            int contador = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                char inicial = nomes[i][0];

                if (inicial == 'A' || inicial == 'B' || inicial == 'C')
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
