namespace Saudacao
{
    internal class Program
    {
        /* 1. Crie um aplicação que peça o nome e apelido e responda com "Olá, Nome e Apelido. Como Vai?" */
        
        static void Main(string[] args)
        {
            string nome, apelido;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu apelido: ");
            apelido = Console.ReadLine();

            Console.WriteLine($"Ola, {nome} {apelido} Como vai?");


        }
    }
}
