namespace Dem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double joao, ze;
            int anos;

            joao = 1.50;
            ze = 1.10;

            for (anos = 1; ze <= joao; anos++)
            {
                joao = joao + 0.02;
                ze = ze + 0.03;
            }

            Console.WriteLine($"Zee sera maior que joao depois de {anos} anos");
        }
    }
}
