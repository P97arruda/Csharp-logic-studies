namespace Ex_11
{

    // 1. Leia um número inteiro e exiba o valor digitado.
    //    Ex.: Entrada 5 → Saída 5
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Insira um numero Inteiro: ");
            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine($"O numero que voce digitou é: {numero}");
        }
    }
}
