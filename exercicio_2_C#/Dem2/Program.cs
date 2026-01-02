namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ensira o numero inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine($"O {numero} é Positivo");
            }
            else 
            {
                Console.WriteLine($"0 {numero} é NEgativo");
            }
        }
    }
}
