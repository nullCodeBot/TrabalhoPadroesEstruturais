using System;

namespace Decorator
{
    class NotificacaoPush : NotificacaoDecorator
    {
        public NotificacaoPush(INotificacao notificacao) : base(notificacao) { }

        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine($"Enviando Push Notification: {mensagem}");
        }
    }
}