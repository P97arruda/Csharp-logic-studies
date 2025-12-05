namespace Dem18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int numeroSecreto = gerador.Next(1, 21);
            int palpite = 0, tentativas = 3;

            Console.WriteLine("Tens 3 tentativas para tenatr  adivinhar entre 1 e 20");

            while (tentativas > 0)
            {
                Console.Write($"\nTentativa: ");
                int.TryParse(Console.ReadLine(), out palpite);

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Acertaste!");
                    
                }

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O numero é MAIOR");
                }
                else
                {
                    Console.WriteLine("O numero é MENOR");
                }

                tentativas = tentativas - 1;
            }

            Console.WriteLine($"\n Nao acertaste. O numero era: {numeroSecreto}");
        }
    }
}