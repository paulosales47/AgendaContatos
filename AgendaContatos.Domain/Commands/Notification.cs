using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContatos.Domain.Commands
{
    public class Notification
    {
        public string Id { get; set; }
        public string Mensagem { get; set; }

        public Notification(string id, string mensagem)
        {
            Id = id;
            Mensagem = mensagem;
        } 
    }
}
