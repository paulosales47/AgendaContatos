using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos.Domain.Commands
{
    public class Response
    {
        public bool Sucesso { get; set; }
        public object Resposta { get; set; }
    }
}
