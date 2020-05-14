using FluentValidation.Results;
using System;

namespace TransportadoraFabriq.Shared.Entities
{
    public abstract class Entity
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

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        #region operators

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        #endregion
    }
}
