using FluentValidation.Results;
using System;

namespace TransportadoraFabriq.Shared.Entities
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;

        }

        public Entity(string usuarioCadastro) : base()
        {
            UsuarioCadastro = usuarioCadastro;
        }

        public Guid Id { get; private set; }

        public string UsuarioCadastro { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public string UsuarioAtualizacao { get; private set; }

        public DateTime DataAtualizacao { get; private set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool Valid { get; private set; }

        public bool Invalid => !Valid;
    }
}
