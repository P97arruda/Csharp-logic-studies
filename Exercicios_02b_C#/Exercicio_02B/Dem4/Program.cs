namespace Dem4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int quantidade, codigo;
            double total = 0;
            

            Console.Write("Código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            if (codigo == 1001)
            {
                total = 5.32 * quantidade;
            }
            else if (codigo == 1324)
            { 
                total = 6.45 * quantidade;
            }
            else if (codigo ==6548)
            {
                total = 2.37 * quantidade;
            }
            else if(codigo == 0987)
            {
                total = 5.32 * quantidade;
            }
            else if (codigo == 7623)
            {
                total = 6.45 * quantidade;
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }

            Console.WriteLine($"Preço total: {Math.Round(total, 2)}");
        }
    }
}
