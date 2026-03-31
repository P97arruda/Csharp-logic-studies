namespace Ex_1
{
    internal class Program
    {
        // Leia um número de 1 a 4 e exiba a operação correspondente
        // (1 = Soma, 2 = Subtração, 3 = Multiplicação, 4 = Divisão).
        // Ex.: Entrada 1 → Saída Soma

        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Soma");
                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    break;
                case 3:
                    Console.WriteLine("Multiplicação");
                    break;
                case 4:
                    Console.WriteLine("Divisão");
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }
        }
    }
}
