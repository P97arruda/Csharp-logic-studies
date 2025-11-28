namespace Dem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado = 0;

            Console.Write("Insira o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira o segundo numero: ");
            int.TryParse(Console.ReadLine(), out numero2);

           
            while(numero1 <= numero2)
            {
               resultado = resultado + numero1;
                numero1++;
            }
            
            Console.WriteLine($" A Somatoria do numero1 a numero2 e {resultado}");
        }
    }
}