namespace Dem6
{
    internal class Program
    {
       // Elabore funções que convertam um determinado número de segundos em horas e minutos.
        static void Main(string[] args)
        {
           // int segundos;
            int  segundos;
            int horas;
            int minutos;

            segundos = PedirSegundos();

            horas = ConversorHoras(segundos);
            minutos = ConversorMinutos(segundos);

            Console.WriteLine($"Resultado: {horas}h {minutos}min");

        }
        /// <summary>
        /// Solicita ao utilizador a quantidade de segundos.
        /// </summary>
        /// <returns>Quantidade de segundos.</returns>
        static int PedirSegundos() 
        {
            int segundos = 0;

            Console.WriteLine("Ensira qualtos segundos deseja converter em hora e minutos: ");
            int.TryParse(Console.ReadLine(), out segundos);

            return segundos;
        }

        /// <summary>
        /// Converte segundos em horas.
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns>Total de horas.</returns>
        static int ConversorHoras(int  segundos) 
        {
            int horas;

            horas = segundos / 3600;
            
            return horas;
        }

        /// <summary>
        /// Converte segundos em minutos.
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns>Total de minutos.</returns>
        static int  ConversorMinutos(int segundos)
        {
            int minutos;

            minutos = (segundos % 3600) / 60;

            return minutos;
        }
    }
}
