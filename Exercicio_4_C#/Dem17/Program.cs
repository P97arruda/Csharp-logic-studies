namespace Dem17
{
    internal class Program
    {
        enum EstadoPedido { Pedente = 1, Processando = 2, concluido = 3}
        static void Main(string[] args)
        {
            int numero;


            Console.Write("Insira um codigo: ");
            int.TryParse(Console.ReadLine(), out numero);

            EstadoPedido pedidos = (EstadoPedido)numero;



            Console.WriteLine($"O pedido está {pedidos}");



           /*
            switch (pedidos) 
            {

                case EstadoPedido.Pedente:
                    Console.WriteLine("O pedido esta pedente");
                    break;

                case EstadoPedido.Processando:
                    Console.WriteLine("O Pedido esta em processo");
                    break;

                case EstadoPedido.concluido:
                    Console.WriteLine("O pedido esta concluido");
                    break;

                default:
                    Console.WriteLine("Codigo Invalido!");
                    break;
            
            }
           */


        }
    }
}
