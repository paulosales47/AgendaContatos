using AgendaContatos.Domain.Entities.Base;
using AgendaContatos.Domain.Enums;

namespace AgendaContatos.Domain.Entities
{
    internal class Grupo: EntityBase
    {
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
        public Usuario Usuario { get; set; }
    }
}
