using System.ComponentModel;

namespace Dem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, final, parcela;
            int codigo, prestacoes = 0;

            Console.Write("Preco do produto: ");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Codigo pagamento: (1-4) ");
            codigo = Convert.ToInt32(Console.ReadLine());


            switch (codigo) 
            {
                case 1:
                    final = preco * 0.70;
                    prestacoes = 1;
                    break;
                
                case 2:
                    final = preco * 0.80;
                    prestacoes = 2;
                    break;

                case 3:
                    final = preco * 0.90;
                    prestacoes = 3;
                    break;

                case 4:
                    final = preco;
                    Console.Write("Outras oopcoes 4 e 6 prestacoes: ");
                    prestacoes = Convert.ToInt32(Console.ReadLine());

                    if(prestacoes == 4)
                    {
                        prestacoes = prestacoes; 
                    }
                    else if(prestacoes == 5)
                    {
                        prestacoes = prestacoes;
                    }
                    else if(prestacoes == 6)
                    {
                        prestacoes = prestacoes;
                    }
                    else
                    {
                        prestacoes = 6;
                        Console.WriteLine("Numero invalido! Usando 6 prestacoes");
                    }
                   break;


                default:
                    final = preco;
                    prestacoes = 1;
                    Console.WriteLine("Codigo invalido");
                    break;

            }

            parcela = final / prestacoes;

            Console.WriteLine($"Preco final: {final}");
            Console.WriteLine($"Prestacoes: {prestacoes}");
            Console.WriteLine($"Valor por prestacoes: {parcela}");

                
        }
    }
}
