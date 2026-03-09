using ExercicioCronometro;


namespace CronometroConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var relogio = new Cronometro();

            Console.WriteLine("Pressione Enter Para iniciar o Cronometro");
            Console.ReadLine();

            relogio.StartClock();
            Console.WriteLine("Pressione Enter Para parar o cronomentro");

            while (relogio.ClockSkate()) 
            {
                var tempo = DateTime.Now - relogio.StartTime();
                Console.Write("\r Tempo Corrente: {0}", tempo);

                if(Console.KeyAvailable)
                {
                    if(Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            relogio.StopClock();

            Console.WriteLine("\r Tempo Cronometrado: {0}", relogio.GetTimeSpan());
        }
    }
}
