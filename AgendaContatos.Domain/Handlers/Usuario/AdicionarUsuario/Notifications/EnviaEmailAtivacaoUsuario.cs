using AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario;
using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.Handlers.Usuario.AdicionarUsuario.Notifications
{
    internal class EnviaEmailAtivacaoUsuario : INotificationHandler<AdicionarUsuarioNotification>
    {
        public async Task Handle(AdicionarUsuarioNotification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(1000).ConfigureAwait(false);
            Debug.WriteLine($"E-mail de ativação enviado para {notification.Usuario.Email}");
        }
    }
}
