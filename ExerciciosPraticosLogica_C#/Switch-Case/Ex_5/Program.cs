namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.Write("Insira um codigo: ");
             codigo = Convert.ToInt32(Console.ReadLine());

            switch(codigo)
            {
                case 1:
                    Console.WriteLine("Inglish");
                    break;
                case 2:
                    Console.WriteLine("Portuguese");
                    break;
                case 3:
                    Console.WriteLine("Germany");
                    break;
                case 4:
                    Console.WriteLine("France");
                    break;

                default:
                    Console.WriteLine("Ingland");
                    break;
            }

        }
    }
}
