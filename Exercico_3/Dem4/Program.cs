using System.ComponentModel;

namespace Dem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco;
            int codigo, prestacoes;

            Console.Write("Insira o preco: ");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o codigo: ");
            codigo = Convert.ToInt32(Console.ReadLine());


            switch (codigo) 
            {
                case 1:
                    Console.WriteLine($"Valor a pagar de {preco - preco * 0.3}");
                    break;
                
               case 2:
                    Console.WriteLine($"Duas prestacoes de {(preco - (preco * 0.2)) /2}");
                    break;

               case 3:
                    Console.WriteLine($"Tres prestacoes de {(preco - (preco * 0.1)) / 3}");
                    break;

                case 4:
                    Console.WriteLine("Quantas prestacoes sao? 4, 5 ou 6");
                    prestacoes = Convert.ToInt32(Console.ReadLine());

                    switch (prestacoes)
                    {
                        case 4:
                            Console.WriteLine($"Quatro prestacoes de {preco / 4}");
                            break;

                        case 5:
                            Console.WriteLine($"Cinco prestacoes de {preco / 5}");
                            break;

                        case 6:
                            Console.WriteLine($"Seis prestacoes de {preco / 6}");
                            break;

                        default:
                            Console.WriteLine("So pode escolher 4, 5 ou 6 prestacoes!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Codigo de pagamento invalido");
                    break;


            }
        }
    }
}
