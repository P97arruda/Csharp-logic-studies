using System.Runtime.InteropServices;

namespace SenhaCorreta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;

            

            while (senha != 2002)
            {


                Console.Write("Insira a senha: ");
                int.TryParse(Console.ReadLine(), out senha);


                if (senha != 2002)
                {
                    Console.WriteLine("Tente novamente");
                    
                }
            }
                
            Console.WriteLine("Acesso permitido");





        }
    }
}
