namespace Ex_3
{
    internal class Program
    {
        //  Leia números e some-os até que o usuário digite um número negativo e some todos no final.
        static void Main(string[] args)
        {
            int numero = 0, soma = 0;

            

            while (numero >= 0)
            {
                Console.Write("Insira um numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero >= 0)
                {
                    soma += numero;
                }

            }

            Console.WriteLine($"A soma dos numero digitados {soma}");


        }
    }
}
