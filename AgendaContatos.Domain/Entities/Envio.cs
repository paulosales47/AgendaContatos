using System;

namespace AgendaContatos.Domain.Entities
{
    public class Envio
    {
        public Guid IdEnvio { get; set; }
        public Campanha Campanha { get; set; }
        public Grupo Grupo { get; set; }
        public Contato Contato { get; set; }
        public bool Enviado { get; set; }
    }
}
