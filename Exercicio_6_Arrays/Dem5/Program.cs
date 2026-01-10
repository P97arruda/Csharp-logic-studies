namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho1;
            
            Console.Write("Insira o tamanho do primiero Array: ");
            int.TryParse(Console.ReadLine(), out tamanho1);

            int[] numero = new int[tamanho1];

            for (int i = 0; i <numero.Length; i++)
            {
                do
                {
                    Console.Write($"Insira um numero para o primiero Array: {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out numero[i]));

            }
        }
    }
}
