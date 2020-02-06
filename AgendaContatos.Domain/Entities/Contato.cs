using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos.Domain.Entities
{
    public class Contato
    {
        public Guid IdContato { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Nicho { get; set; }
    }
}
