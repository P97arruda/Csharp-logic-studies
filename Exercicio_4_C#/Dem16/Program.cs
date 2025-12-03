namespace Dem16
{
    internal class Program
    {
        enum diasSemana { Domingo = 1 , Segunda = 2, Terca = 3, Quarta = 4, Quinta = 5, Sexta = 6, Sabado = 7}
        static void Main(string[] args)
        {

            int numero;
            
            Console.Write("Insita um numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            diasSemana dias = (diasSemana)numero;

            switch(dias)
            {
                case diasSemana.Domingo:
                Console.WriteLine("Domingo");
                break;

                case diasSemana.Segunda:
                    Console.WriteLine("Segunda-feira");
                    break;

                case diasSemana.Terca:
                    Console.WriteLine("Terca-feira");
                    break;

                case diasSemana.Quarta:
                    Console.WriteLine("Quarta-feira");
                    break;

                case diasSemana.Quinta:
                    Console.WriteLine("Quinta-feira");
                    break;

                case diasSemana.Sexta:
                    Console.WriteLine("Sexta-feira");
                    break;

                case diasSemana.Sabado:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Numero invalido.");
                    break;
            }
           
        }
           
    }
}
