namespace Ex_5
{
    internal class Program
    {
        // Leia uma senha até que ela esteja correta.
        static void Main(string[] args)
        {
            int senha;

            int  tentativa = 5;

            while (tentativa > 0)
            {
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha == 1234)
                {
                    Console.WriteLine("Acesso Perimito");
                    break;
                }

                tentativa--;
                Console.WriteLine($"Senha irote. Tentativas restantes {tentativa}");
            }

            if (tentativa == 0)
            {
                Console.WriteLine("Conta bloqueada. Procure a agência mais próxima.");
            }

        }
    }
}
