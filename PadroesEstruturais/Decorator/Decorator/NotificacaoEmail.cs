using System;

namespace Decorator
{
    class NotificacaoEmail : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando Email: {mensagem}");
        }
    }
}