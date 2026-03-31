namespace Ex_4
{
     // 4. Leia um nome e exiba “Olá, [nome]!”.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}!");
        }
    }
}
