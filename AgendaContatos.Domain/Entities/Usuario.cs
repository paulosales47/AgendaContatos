using AgendaContatos.Domain.Entities.Base;
using AgendaContatos.Domain.Extensions;
using System;

namespace AgendaContatos.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }

        public Usuario(string primeiroNome, string ultimoNome, string senha, string email)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Senha = senha;
            Email = email;

            if (string.IsNullOrEmpty(this.Senha))
                Senha = Senha.ToSHA3512();

            DataCadastro = DateTime.Now;
            Ativo = false;
        }
    }
}
