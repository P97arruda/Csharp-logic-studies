namespace Dem6
{
    internal class Program
    {
       // Elabore funções que convertam um determinado número de segundos em horas e minutos.
        static void Main(string[] args)
        {
           // int segundos;
            double segundos;

            segundos = PedirSegundos();

            Console.WriteLine($"Resultado: {Conversor(Math.Round(segundos,2))}");

        }

        static int PedirSegundos() 
        {
            int segundos = 0;

            Console.WriteLine("Ensira qualtos segundos deseja converter em hora e minutos: ");
            int.TryParse(Console.ReadLine(), out segundos);

            return segundos;
        }

        static double Conversor(double  segundos) 
        {
            //int horas, minutos;
            double horas , minutos;

            horas = segundos / 3600;
            //minutos = (segundos % 3600) / 60;


            return horas;
        }
    }
}
