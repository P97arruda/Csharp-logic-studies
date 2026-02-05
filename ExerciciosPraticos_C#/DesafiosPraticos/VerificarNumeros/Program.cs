namespace VerificarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            
            int.TryParse(Console.ReadLine(), out numero);

            if (numero > 0 ) 
            {
                Console.WriteLine("POSITIVO");
            }
            else if (numero < 0)          {
                Console.WriteLine("NEGATIVO");
            }
            else  
            {
                Console.WriteLine("Zero");
            }

        }
    }
}
