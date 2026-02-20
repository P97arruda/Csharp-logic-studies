namespace ExercicioSoma
{
    internal class Program
    {
        // Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        // mensagem explicativa, conforme exemplos.

        static void Main(string[] args)
        {
            int numero1, numero2, total;

            Console.Write("Insira o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira o segundo numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

            total = numero1 + numero2;

            Console.WriteLine($"SOMA = {total}");

        }
    }
}
