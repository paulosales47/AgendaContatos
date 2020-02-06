using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos.Domain.Entities
{
    public class Campanha
    {
        public Guid IdCampanha { get; set; }
        public string Nome { get; set; }
        public Usuario Usuario { get; set; }
    }
}
