
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Transactions;

namespace dem1
{
    internal class Program
    {
        /*
         * Numa enfermaria existem 4 camas (cama 1, cama 2, cama 3 e cama 4) onde se encontram 4
          pacientes.
          De hora em hora são medidas as pulsações a cada paciente (ao longo do dia = 24 leituras para
          cada paciente)
          Desenvolva um programa que:
          
        a) Proceda á leitura e armazenamento numa matriz de dimensão 24*4 dos valores das
           pulsações dos 4 pacientes ao longo das 24 horas de um dia;

        b) Calcular e apresentar a média das pulsações para cada um dos pacientes;

        c) Identificar a cama onde se encontra o paciente que apresentou o maior valor médio das
           pulsações;

        d) Identificar o valor mais elevado armazenado na matriz, e a identificação da cama e da hora
           em que ocorreu.
        */

        static void Main(string[] args)
        {
            
            int[,] infermaria = new int[4, 24];

            for (int i = 0; i < 4; i++) // camas
            {
                for (int j = 0; j < 24; j++) // horarios
                {
                    do
                    {

                        Console.Write($"Ensira a pusação do paciencia cama {i + 1} no horario {j + 1} : ");

                    } while (!int.TryParse(Console.ReadLine(), out infermaria[i, j]));
                }

            }


            for (int i = 0; i < 4; i++) 
            {
                Console.Write($"Cama {i + 1}: ");
                for (int j = 0; j < 24; j++)
                {
                    Console.Write(infermaria[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para ver a média das pulsações...");
            Console.ReadKey();
            Console.Clear();




            int soma = 0;
            double[] media = new double[4];
                
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 24; j++)
                {
                    soma += infermaria[i, j];
                }
                media[i] = soma / 24.0;
                Console.WriteLine($"Cama {i + 1} - Media: {Math.Round(media[i],2)}");
            }

            Console.WriteLine("Pressione qualquer tecla para ver a  o maior valor médio das o maior valor médio das pulsações.");
            Console.ReadKey();
            Console.Clear();


            double maiorMadia = media[0];
            int camaMaior = 1;

            for (int i = 0; i < 4; i++)
            {
                if (media[i] > maiorMadia)
                {
                    maiorMadia = media[i];
                    camaMaior++;
                }
               
            }
                Console.WriteLine($"Cama com maior média: {Math.Round(maiorMadia, 2)}");

            
            Console.WriteLine("Pressione qualquer tecla para ver a a identificação da cama e da hora em que ocorreu....");
            Console.ReadKey();
            Console.Clear();

            int maior = infermaria[0, 0];
            int horaMaior = 1;

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0;j < 24; j++)
                {
                    if (infermaria[i, j] >maior)
                    {
                        maior = infermaria[i, j];
                        camaMaior = i + 1;
                        horaMaior = j + 1;
                    }
                }
            }

            Console.WriteLine($"Maior pulsação registrada: {maior} Cama: {camaMaior} Hora: {horaMaior}");

        }
    }

}
