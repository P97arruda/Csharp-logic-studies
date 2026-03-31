namespace CodigoItens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total = 0;
            double CachorroQuente = 4.00, Xsalada = 4.50, Xbacon = 5.00, TorradaSimples = 2.00, Refrigerante = 1.50;

            do
            {

                Console.Write("Insira o codigo do produto: ");
                

            } while(!int.TryParse(Console.ReadLine(), out codigo));


            do
            {

                Console.Write("Insira quantidade: ");


            } while (!int.TryParse(Console.ReadLine(), out quantidade));



            if (codigo >= 1 && codigo <= 5)
            {
                if (codigo == 1)
                {
                    total = quantidade * CachorroQuente;
                   
                }
                else if (codigo == 2) 
                {
                    total = quantidade * Xsalada;
                    
                }
                else if (codigo == 3)
                {
                    total = quantidade * Xbacon;
                   
                }
                else if(codigo == 4)
                {
                    total = quantidade * TorradaSimples;
                    
                }
                else if (codigo == 5)
                {
                    total = quantidade * Refrigerante;
                    
                }

                Console.WriteLine($"Total: R$ {Math.Round(total, 2)}");
            }
            else
            {
                Console.WriteLine("Codigo Invalido");
            }
          

        }
    }
}
