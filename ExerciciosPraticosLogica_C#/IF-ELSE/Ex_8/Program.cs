namespace Ex_8
{
    internal class Program
    {
        // Leia dois números inteiros e informe se são iguais ou diferentes.
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

            if (numero1 == numero2)
            {
                Console.WriteLine("Os numeros sao iguais.");
            }
            else
            {
               Console.WriteLine("Os numeros sao diferentes.");

            }
        }
    }
}
