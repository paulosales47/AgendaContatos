using MediatR;

namespace AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario
{
    internal class AdicionarUsuarioNotification: INotification
    {
        public AdicionarUsuarioNotification(Entities.Usuario usuario)
        {
            Usuario = usuario;
        }

        public Entities.Usuario Usuario { get; private set; }

    }
}
