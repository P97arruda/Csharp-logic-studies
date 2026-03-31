namespace Ex_2
{
    internal class Program
    {
         // Leia um número inteiro e informe se é positivo ou negativo.
         //  Ex.: Entrada -3 → Saída Negativo


        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);


            if(numero >= 0)
            {
                Console.WriteLine("O numero inserido e positivo.");
            }
            else
            {
                Console.WriteLine("O numero inserido e negativo.");
            }
        }
    }
}
