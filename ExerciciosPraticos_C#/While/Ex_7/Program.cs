namespace Ex_7
{
    internal class Program
    {
        // Leia números e calcule a soma até ultrapassar 500.
        static void Main(string[] args)
        {
            int soma = 0;
            int numero;

            while (soma <= 500) 
            { 
                Console.Write("Digite um número para somar: ");
                int.TryParse(Console.ReadLine(), out numero);
                
                if(numero < 500)
                {
                    soma += numero;
                    

                }
                
            }
        }
    }
}
