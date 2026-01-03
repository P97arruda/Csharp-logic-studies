namespace Ex_1
{
    internal class Program
    {
        //Leia um número inteiro e informe se é par ou ímpar.
        // Ex.: Entrada 4 → Saída Par

        static void Main(string[] args)
        {
            int numero; 

            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out numero);


            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero inserido e par.");
            }
            else
            {
                Console.WriteLine("O numero inserido e impar.");


            }

            


        }
    }
}
