namespace Ex_6
{
    internal class Program
    {
        // Leia a nota de um aluno e informe se está aprovado, recuperação ou reprovado.
        // Ex.: Entrada 5 → Saída Recuperação


        static void Main(string[] args)
        {
            double nota;

            Console.Write("Insira uma nota: ");
            double.TryParse(Console.ReadLine(), out nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 4.0)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
