namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            char resposta = 's';
            

            Console.Write("Insira sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            while (resposta == 's')
            {
                if (idade < 18)
                {
                    Console.WriteLine("Você é menor de idade.");
                }
                else
                {
                    Console.WriteLine("Você é maior de idade.");
                }
                Console.Write("Deseja verificar outra idade? (s/n): ");
                char.TryParse(Console.ReadLine(), out resposta);
                if (resposta == 's')
                {
                    Console.Write("Insira sua idade: ");
                    int.TryParse(Console.ReadLine(), out idade);
                }
                 
            }
        }
    }
}
