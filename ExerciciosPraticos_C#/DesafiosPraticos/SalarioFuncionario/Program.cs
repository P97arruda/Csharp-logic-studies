using System;
using System.Drawing;

namespace SalarioFuncionario
{
    internal class Program
    {
        // Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        // hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
        // decimais.
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhada;
            double valorHora, salario;

            Console.Write("Insira seu numero de funcionario: ");
            int.TryParse(Console.ReadLine(), out numeroFuncionario);

            Console.Write("Insira seu numero de horas trabalhada: ");
            int.TryParse(Console.ReadLine(), out horasTrabalhada);

            Console.Write("Insira o valor que recebe por hora: ");
            double.TryParse(Console.ReadLine(),out valorHora);

            salario = horasTrabalhada * valorHora;

            Console.WriteLine($"NUMEBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:f2}");

            
         
        }
    }
}
