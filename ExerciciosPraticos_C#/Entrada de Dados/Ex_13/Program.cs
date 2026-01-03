namespace Ex_13
{
    // 13. Leia um salário de um funionario e aumente 10% seu salário.
    //     // Ex.: 1000 → 1100
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double salario;

            Console.Write("Insira seu Salario: ");
            double.TryParse(Console.ReadLine(), out salario);

            salario = salario * 1.10;


            Console.WriteLine($"Seu novo salario com aumento de 10% é: {salario}");

        }
    }
}
