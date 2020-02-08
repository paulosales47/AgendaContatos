using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario.Notifications
{
    internal class EnviaEmailAtivacaoUsuario : INotificationHandler<AdicionarUsuarioNotification>
    {
        public async Task Handle(AdicionarUsuarioNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"E-mail de ativação enviado para {notification.Usuario.Email}");
        }
    }
}
