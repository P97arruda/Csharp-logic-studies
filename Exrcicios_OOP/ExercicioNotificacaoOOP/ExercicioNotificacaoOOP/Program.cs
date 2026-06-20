namespace ExercicioNotificacaoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INotificacao> canais = new List<INotificacao>
            {
                new NotificacaoEmail(),
                new NotificacaoSMS(),
                new NotificacaoPush()
            };


            foreach (var notificacao in canais)
            {
                Console.WriteLine(notificacao);
            }
        }
    }
    
}
