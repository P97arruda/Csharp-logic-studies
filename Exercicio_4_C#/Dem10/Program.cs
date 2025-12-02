namespace Dem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double joao, ze;
            int anos = 0;

            joao = 1.50;
            ze = 1.10;

            while (ze <= joao) 
            {
                joao = joao + 0.02;
                ze = ze + 0.03;
                anos = anos + 1;
            }

            Console.WriteLine($"Ze sera maoir que joao depois de {anos} anos");

        }
    }
}
