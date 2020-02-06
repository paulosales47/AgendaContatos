using AgendaContatos.Domain.Entities.Base;

namespace AgendaContatos.Domain.Entities
{
    public class Grupo: EntityBase
    {
        public string Nome { get; set; }
        public int Nicho { get; set; }
        public Usuario Usuario { get; set; }
    }
}
