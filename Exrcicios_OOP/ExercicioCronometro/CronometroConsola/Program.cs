using ExercicioCronometro;


namespace CronometroConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var relogio = new Cronometro();

            // Aguarda o utilizador para iniciar o cronómetro 
            Console.WriteLine("Pressione Enter Para iniciar o Cronometro");
            Console.ReadLine();

            relogio.StartClock();
            Console.WriteLine("Pressione Enter Para parar o cronomentro");

            // Atualiza o tempo no ecrã enquanto o cronómetro estiver ativo 
            while (relogio.ClockSkate()) 
            {
                var tempo = DateTime.Now - relogio.StartTime();
                Console.Write("\r Tempo Corrente: {0}", tempo);

                // Verifica se o utilizador premiu Enter para parar 
                if(Console.KeyAvailable)
                {
                    if(Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            relogio.StopClock();

            // Mostra o tempo total cronometro
            Console.WriteLine("\r Tempo Cronometrado: {0}", relogio.GetTimeSpan());
        }
    }
}
