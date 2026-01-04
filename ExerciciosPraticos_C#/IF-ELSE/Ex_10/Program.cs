namespace Ex_10
{
    internal class Program
    {
        // Leia um ano e informe se é bissexto.
        static void Main(string[] args)
        {

            int ano;

            Console.Write("Insira o ano: ");
            int.TryParse(Console.ReadLine(), out ano);

            // 1ª condição: ano divisível por 400
            if (ano % 400 == 0)
            {
                Console.WriteLine($"O ano {ano} é bissexto.");
            }
            // 2ª condição: divisível por 100 (mas não por 400)
            else if (ano % 100 == 0)
            {
                Console.WriteLine($"O ano {ano} não é bissexto.");
            }
            // 3ª condição: divisível por 4
            else if (ano % 4 == 0)
            {
                Console.WriteLine($"O ano {ano} é bissexto.");
            }
            // Caso contrário
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto.");
            }
        }
    }
}
