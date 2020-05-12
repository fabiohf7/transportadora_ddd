using System;

namespace TransportadoraFabriq.Domain.Entities
{
    public class Cliente
    {
        public Cliente(Guid id, string nome, string sobrenome, string email, string documento, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Documento = documento;
            DataCadastro = dataCadastro;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Email { get; private set; }

        public string Documento { get; private set; }

        public DateTime DataCadastro { get; private set; }
    }
}
