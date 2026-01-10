namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numero = new int[5];
            int quantidade;
            

            Console.Write("Insira o tamanho do Array: ");
            int.TryParse(Console.ReadLine(), out quantidade);

            int[] numero = new int[quantidade];

            for (int i = 0; i < numero.Length; i++)
            {
                do
                {
                    Console.Write($" Insira um numero: {i + 1}: ");

                } while (!int.TryParse(Console.ReadLine(), out numero[i]));

            }

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($" Os Numeros que estão dentro do Array: {i + 1} e: {numero[i]}");
            }


        }
    }
}
