namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoCusto, precoVenda, margem = 0;
               
            int codigoCategoria;

            Console.Write("Preco de custo do produto: ");
            precoCusto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Codigo do produto 1 a 6: ");
            codigoCategoria = Convert.ToInt32(Console.ReadLine());

            switch (codigoCategoria)
            {
                case 1:
                case 2:
                    margem = 0.80;
                    break;

                case 3:
                case 4:
                    margem = 1.00;
                    break;

                case 5:
                case 6:
                    margem = 0.90;
                    break;
                default:
                    Console.WriteLine("codigo invalido!");
                    break;
            }

            precoVenda = precoCusto + (precoCusto * margem);


            Console.WriteLine($"Margem de lucro: {margem * 100}%");
            Console.WriteLine($"Preço de venda: {Math.Round(precoVenda, 2)}€");





        }
    }
}
