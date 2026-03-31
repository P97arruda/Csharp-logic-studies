namespace EntradaDeDados
{
    internal class Program
    {
        // Leia um número inteiro informado pelo utilizador.
        // O valor deve ser armazenado pelo utilizador.
        // O programa deve mostra exatamente o valor.

        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);


            Console.WriteLine($"{numero}");
        }
    }
}
