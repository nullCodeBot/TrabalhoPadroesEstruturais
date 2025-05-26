namespace Decorator
{
    abstract class NotificacaoDecorator : INotificacao
    {
        protected INotificacao _notificacao;

        public NotificacaoDecorator(INotificacao notificacao)
        {
            _notificacao = notificacao;
        }

        public virtual void Enviar(string mensagem)
        {
            _notificacao.Enviar(mensagem);
        }
    }
}