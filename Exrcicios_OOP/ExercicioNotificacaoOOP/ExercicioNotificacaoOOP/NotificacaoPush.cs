using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioNotificacaoOOP
{
    internal class NotificacaoPush : INotificacao
    {
        public void EnviarMensagem(string destinatario, string mensagem)
        {
            Console.WriteLine($"[EMAIL] Para: {destinatario} | Mensagem: {mensagem}");
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
