using FluentValidation.Results;
using System;

namespace TransportadoraFabriq.Shared.Entities
{
    public class Entity
    {
        public Guid Id { get; private set; }

        public string UsuarioCadastro { get; private set; }

        public DateTime? DataHoraCadastro { get; private set; }

        public string UsuarioAlteracao { get; private set; }

        public DateTime? DataHoraAlteracao { get; private set; }

        public bool Valid { get; private set; }

        public bool Invalid => !Valid;

        public ValidationResult ValidationResult { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            DataHoraCadastro = DateTime.Now;
            ValidationResult = new ValidationResult();
        }

        public Entity(string usuarioCadastro)
        {
            UsuarioCadastro = usuarioCadastro;
        }

    }
}
