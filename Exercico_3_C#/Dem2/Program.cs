namespace Dem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco = 0;

            Console.Write("Insira o codigo do produto: ");
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

            Console.WriteLine($"O valor a pagar pela pelo lanche e: {preco}");



            /*
             * int codigo, quantidade;
             * string texto = string,Empty;
             * float preco = 0;
             * bool codigoValido = true;
             * 
             * 
             *  Console.Write("Insira o codigo");
             *  codigo = Convert.ToInt32(Console.ReadLine());
             *  
             *  
             *  
             *  swuitc(codigo)
             *  {
             *      case 100:
             *          texto = "Cachorro quente";
             *          preco = 2.5f;
             *          break;
             *     
             *      case 101:
             *          text...
             *          
             *      default:
             *          codigoValido = false;
             *          preco + 0;
             *          break;
             *          
             *          
             *   if(codigoValido)
             *   {
             *      console.Write("Insira a Quantidade: ");
             *      quantidade = Convert.ToInt32(Console.ReadLine());
             *      Console.Write($"Valor a pagar : {quantidade} * {preco} ->{texto} ={quantidade * preco}");
             *   }
             *   else
             *   {
             *      Console.WriteLine("Codigo invalido");
             *   }
             *  
                    
             *  
             *  }
             */
        }
    }
}