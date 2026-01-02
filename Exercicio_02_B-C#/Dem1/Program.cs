namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeNadador;

            Console.WriteLine("Introduza a idade do nadador:  ");
            
            idadeNadador = Convert.ToInt32(Console.ReadLine());

            if (idadeNadador >= 5)
            {
                if (idadeNadador <= 7)
                {
                    Console.WriteLine("Infatil A");
                }
                else if (idadeNadador <= 10)
                {
                    Console.WriteLine("Infantil B");
                }
                else if (idadeNadador <= 13)
                {
                    Console.WriteLine("Juvenil A");
                }
                else if (idadeNadador <= 17)
                {
                    Console.WriteLine("Juvenil B");
                }
                else if(idadeNadador >= 18)
                {
                    Console.WriteLine("Categoria adulta");
                }
            }
            else 
            {
                Console.WriteLine("Esta idade não corresponde a nenhuma categoria");
            }



        }
    }
}
