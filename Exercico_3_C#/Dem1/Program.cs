namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de decisao - SWITCH

            int numero;

            Console.Write("Insira um numero entre 0 e 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero) 
            {
                case 0:
                    Console.WriteLine("Numero Zero");
                    break;
                
                case 1:
                    Console.WriteLine("Numero Um");
                    break;
                
                case 2:
                    Console.WriteLine("Numero Dois");
                    break;

                case 3:
                    Console.WriteLine("Numero Tres");
                    break;
                    
                case 4:
                    Console.WriteLine("Numero Quatro");
                    break;
                    
                case 5:
                    Console.WriteLine("Numero Cinco");
                    break;

                case 6:
                    Console.WriteLine("Numero Seis");
                    break;
                case 7:
                    Console.WriteLine("Numero Sete");
                    break;
                case 8:
                    Console.WriteLine("Numero Oito");
                    break;
                case 9:
                    Console.WriteLine("Numero Nove");
                    break;
                case 10:
                    Console.WriteLine("Numero Dez");
                    break;

                default:
                    Console.WriteLine("Numero invalido");
                    break;
               

            }
        }
    }
}
