using AgendaContatos.Domain.Entities.Base;

namespace AgendaContatos.Domain.Entities
{
    internal class Envio: EntityBase
    {
        public Campanha Campanha { get; set; }
        public Grupo Grupo { get; set; }
        public Contato Contato { get; set; }
        public bool Enviado { get; set; }
    }
}
