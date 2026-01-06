namespace Ex_4
{
    internal class Program
    {
        // Leia uma nota e continue pedindo até que seja válida (0 a 10).
        static void Main(string[] args)
        {
            int nota = 0;
            int contador = 1;

            while (nota >= 0 && nota <= 10)
            {
                Console.Write($"Insira uma nota (0 a 10) nota {contador}: ");
                int.TryParse(Console.ReadLine(), out nota);
                contador++;
            }
            Console.WriteLine("Nota inválida. Programa encerrado.");
        }
    }
}
