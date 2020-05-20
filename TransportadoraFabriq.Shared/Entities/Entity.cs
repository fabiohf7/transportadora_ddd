using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Shared.Entities
{
    public abstract class Entity
    {
        private List<INotification> _domainEvents;

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        protected Entity()
        {
            Id = Guid.NewGuid();

        }

        public Guid Id { get; private set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool Valid { get; private set; }

        public bool Invalid => !Valid;

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);

            return Valid = ValidationResult.IsValid;
        }

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public void AddDomainNotification(string message)
        {
            AddDomainEvent(new NotificationDomain(message));
        }

        public void AddDomainNotification()
        {
            foreach (var error in this.ValidationResult.Errors)
            {
                AddDomainEvent(new NotificationDomain(error.ErrorMessage));
            }
        }

        public void AddDomainNotification(string messageId, string message)
        {
            AddDomainEvent(new NotificationDomain(messageId, message));
        }

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
