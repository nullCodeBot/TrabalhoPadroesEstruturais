using System;

namespace Decorator
{
    class NotificacaoSMS : NotificacaoDecorator
    {
        public NotificacaoSMS(INotificacao notificacao) : base(notificacao) { }

        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }
}