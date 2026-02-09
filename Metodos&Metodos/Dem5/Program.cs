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
            string[] nome = new string[] {"Maria", "Ana", "Julia", "Carla", "Ana Julia" };

            


            int[] resultado = ContarIniciais(nome);

            Console.WriteLine($"A: {resultado[0]}");
            Console.WriteLine($"B: {resultado[1]}");
            Console.WriteLine($"C: {resultado[2]}");
        }


        /// <summary>
        /// Conta iniciais A, B e C.
        /// </summary>
        /// <param name="nomes"> Array de strings </param>
        /// <returns> Array de contadores. </returns>
        static int[] ContarIniciais (string[] nomes)
        {
            int[] contadores = new int[3];

            for (int i = 0; i < nomes.Length; i++) 
            {
                if (nomes[i][0] == 'A')
                    nomes[i][0] == "B")
                {
                    
                }
                contadores[0]++;
            }

        

            return contadores;
        }

    }
}
