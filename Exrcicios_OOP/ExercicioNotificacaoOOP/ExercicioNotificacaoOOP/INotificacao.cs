using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioNotificacaoOOP
{
    internal interface INotificacao
    {
       void EnviarMensagem(string destinatario, string mensagem);
    }
}
