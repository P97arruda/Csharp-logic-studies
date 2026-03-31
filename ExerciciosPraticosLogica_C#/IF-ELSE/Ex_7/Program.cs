namespace Ex_7
{
    internal class Program
    {
        // Leia dois números inteiros e informe qual é o maior.
        // Ex.: Entrada 5 e 9 → Saída 9
        static void Main(string[] args)
        {
            int numero1, numero2;
            
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

            if (numero1 > numero2)
            {
                Console.WriteLine($"O primeiro numero e maior {numero1}.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O segundo numero e maior {numero2}.");
            }
            else
            {
                Console.WriteLine("Os numeros sao iguais.");
            }



        }
    }
}
