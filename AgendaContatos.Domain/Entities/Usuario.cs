using AgendaContatos.Domain.Entities.Base;

namespace AgendaContatos.Domain.Entities
{
    public class Usuario: EntityBase
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
