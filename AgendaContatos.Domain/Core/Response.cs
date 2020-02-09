using AgendaContatos.Domain.Commands;
using System.Collections.Generic;
using System.Linq;

namespace AgendaContatos.Domain.Core
{
    public class Response
    {
        private readonly List<Notification> _notificacoes;
        public IReadOnlyCollection<Notification> Notificacoes => _notificacoes;
        public bool PossuiNotificacao => _notificacoes.Any();
        public bool Sucesso { get; set; }
        public object Resposta { get; set; }

        public Response()
        {
            _notificacoes = new List<Notification>();
        }

        public Response(object resposta)
        {
            _notificacoes = new List<Notification>();
            Resposta = resposta;
        }

        public void AdicionarNotificacao(Notification notificacao) 
        {
            _notificacoes.Add(notificacao);
        }

        public void AdicionarNotificacao(string id, string mensagem) 
        {
            _notificacoes.Add(new Notification(id, mensagem));
        }

        public void AdicionarNotificacao(IReadOnlyCollection<Notification> notificacoes) 
        {
            _notificacoes.AddRange(notificacoes);
        }

        public void AdicionarNotificacao(IList<Notification> notificacoes)
        {
            _notificacoes.AddRange(notificacoes);
        }

        public void AdicionarNotificacao(ICollection<Notification> notificacoes)
        {
            _notificacoes.AddRange(notificacoes);
        }

    }
}
