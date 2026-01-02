namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.Write("Insira o primeiro numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o terceiro numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());


            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine($"O primeiro, {numero1} é o maior de todos");
                }
                else
                {
                    Console.WriteLine($"O Terceiro, {numero3} é o maior de todos");
                }
            }
            else
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine($"O segundo, {numero2} é o maior de todos");
                }
                else
                {
                    Console.WriteLine($"O Terceiro, {numero3} é o maior de todos");
                }
            }
        }
    }
}
