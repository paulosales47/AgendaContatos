using System;

namespace AgendaContatos.Domain.Entities
{
    public class GrupoUsuario
    {
        public Guid IdGrupo { get; set; }
        public Grupo Grupo { get; set; }
        public Guid IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
