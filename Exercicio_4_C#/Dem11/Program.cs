namespace Dem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //string resultado;

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            //resultado = (numero % 2 == 0) ? "PAR" : "IMPAR";

            Console.Write($"O numero {numero} e {(numero % 2 == 0 ? "PAR" : "IMPAR")}");
        }
    }
}
