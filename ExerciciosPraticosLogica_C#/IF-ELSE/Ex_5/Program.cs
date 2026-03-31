namespace Ex_5
{
    internal class Program
    {
        // Leia a nota de um aluno e informe se está aprovado (nota ≥7).
        //Ex.: Entrada 8 → Saída Aprovado
        static void Main(string[] args)
        {
            double nota;

            Console.Write("Insira sua nota ");
            double.TryParse(Console.ReadLine(), out nota);

            if (nota >= 5.0) 
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
