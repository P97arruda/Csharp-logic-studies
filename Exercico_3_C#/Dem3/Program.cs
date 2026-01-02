namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco = 0;
            string resposta;

            Console.Write("Insira o codigo do produto ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a quantidade do produto: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 100:
                    preco = quantidade * 2.50;
                    break;

                case 101:
                    preco = quantidade * 3.50;
                    break;

                case 102:
                    preco = quantidade * 4.50;
                    break;

                case 103:
                    preco = quantidade * 2.70;
                    break;

                case 104:
                    preco = quantidade * 3.55;
                    break;

                case 105:
                    preco = quantidade * 1.75;
                    break;

                default:
                    Console.WriteLine("Codigo invalido");
                    break;
            }

            
            Console.Write("Deseja adicionar mais itens? (s/n): ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                
                Console.Write("Insira o codigo do pedido: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira a quantidade: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                switch (codigo)
                {
                    case 100:
                        preco = quantidade * 2.50;
                        break;
                    case 101:
                        preco = quantidade * 3.50;
                        break;
                    case 102:
                        preco = quantidade * 4.50;
                        break;
                    case 103:
                        preco = quantidade * 2.70;
                        break;
                    case 104:
                        preco = quantidade * 3.55;
                        break;
                    case 105:
                        preco = quantidade * 1.75;
                        break;
                    default:
                        Console.WriteLine("Codigo invalido");
                        break;
                }

                Console.WriteLine($"O valor a pagar pela pelo lanche e: {preco}");
            }
        }
    }
}
