using AgendaContatos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos.Domain.Entities
{
    public class Campanha: EntityBase
    {
        public string Nome { get; set; }
        public Usuario Usuario { get; set; }
    }
}
