using AgendaContatos.Domain.Entities.Base;

namespace AgendaContatos.Domain.Entities
{
    public class Contato: EntityBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Nicho { get; set; }
        public Usuario Usuario { get; set; }
    }
}
