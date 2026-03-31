namespace Ex_10
{
    //10.Leia um número real e exiba seu valor absoluto.

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             if (numero < 0)
                {
                    numero = numero * -1;
                }

                    Console.WriteLine($"Valor absoluto: {numero}");
                 
               */




            Console.Write("Insira um numero: ");
            double.TryParse(Console.ReadLine(), out double numero);

            double valorAbsoluto = Math.Abs(numero);

            Console.WriteLine($"O valor absoluto do numero é: {valorAbsoluto}");



        }
    }
}
