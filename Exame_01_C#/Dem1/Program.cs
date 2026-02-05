namespace Dem1
{
    internal class Program
    {
        // 1. Atendendo que 1km são aproximadamente 0,62 milhas, desenvolva um programa que
        // permita fazer essa conversão nos dois sentidos.Deve efetuar todas as validações
        // necessárias ao bom funcionamento do programa.

        static void Main(string[] args)
        {
            int opcao = 0;
            double milhas , km, resultado;


            Console.WriteLine();
            Console.WriteLine("Insira (1) para converter Milha em Km ou (2) para converter Km em milha");
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                do
                {
                    Console.WriteLine("Quantas milhas gostaria de converter para Km?");

                } while (!double.TryParse(Console.ReadLine(), out milhas));

                resultado = milhas * 1.609;


                Console.WriteLine($"Resultado: {resultado}");

            }

            else if (opcao == 2) 
            {
                do
                {
                    Console.WriteLine("Quantos km gostaria de converter para milha?");

                } while (!double.TryParse(Console.ReadLine(), out km));

                resultado = km * 0.62;

                Console.WriteLine($"Resultado: {resultado}");

            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }
            
            
               //Console.WriteLine($"Resultado: {resultado}");








           
           





        }
    }
}
