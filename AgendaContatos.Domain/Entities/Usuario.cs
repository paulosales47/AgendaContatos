using System;

namespace AgendaContatos.Domain.Entities
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }

    }
}
