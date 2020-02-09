using AgendaContatos.Domain.Entities.Base;
using AgendaContatos.Domain.Enums;
using System.Collections.Generic;

namespace AgendaContatos.Domain.Entities
{
    public class Grupo: EntityBase
    {
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
        public ICollection<GrupoUsuario> GruposUsuarios { get; set; }
    }
}
