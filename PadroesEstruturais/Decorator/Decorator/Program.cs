namespace Decorator
{
    class Program
    {
        static void Main()
        {
            INotificacao notificacao = new NotificacaoEmail();
            notificacao = new NotificacaoSMS(notificacao);
            notificacao = new NotificacaoPush(notificacao);

            notificacao.Enviar("Promoção imperdível!");
        }
    }
}