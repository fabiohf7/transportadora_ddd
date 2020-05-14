using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Entities;
using TransportadoraFabriq.Shared.Entities.Interfaces;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Shared.Commands
{
    public abstract class CommandHandler
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMediator _mediator;
        protected readonly INotificationHandler<NotificationDomain> _notifications;
        protected readonly ILogger<CommandHandler> _logger;

        public CommandHandler(IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null)
        {
            _uow = uow;
            _mediator = mediator;
            _notifications = notifications;
            _logger = logger;
        }

        protected async void HandleEntity(Entity entity)
        {
            foreach (var error in entity.ValidationResult.Errors)
            {
                await _mediator.Publish(new NotificationDomain(error.PropertyName, error.ErrorMessage));
            }


        }

        protected async void HandleEntities(IEnumerable<Entity> entities)
        {
            if (entities == null)
                return;

            foreach (var item in entities)
            {
                foreach (var error in item.ValidationResult.Errors)
                {
                    await _mediator.Publish(new NotificationDomain(error.PropertyName, error.ErrorMessage));
                }
            }
        }

        public async void AddNotification(string key, string message)
        {
            await _mediator.Publish(new NotificationDomain(key, message));
        }

        public async void AddNotification(NotificationDomain notification)
        {
            await _mediator.Publish(new NotificationDomain(notification.MessageId, notification.Message));
        }

        public async void AddNotifications(IReadOnlyCollection<NotificationDomain> notifications)
        {
            foreach (var item in notifications)
            {
                await _mediator.Publish(new NotificationDomain(item.MessageId, item.Message));
            }
        }

        public async void AddNotifications(IList<NotificationDomain> notifications)
        {
            foreach (var item in notifications)
            {
                await _mediator.Publish(new NotificationDomain(item.MessageId, item.Message));
            }
        }

        public async void AddNotifications(ICollection<NotificationDomain> notifications)
        {
            foreach (var item in notifications)
            {
                await _mediator.Publish(new NotificationDomain(item.MessageId, item.Message));
            }
        }

        protected bool IsSuccess()
        {
            return !((NotificationDomainHandler)_notifications).HasNotifications();
        }

        protected List<NotificationDomain> DomainNotifications()
        {
            return ((NotificationDomainHandler)_notifications).GetNotifications();
        }

        protected async Task CommitAsync()
        {
            _logger.LogTrace("Is success domain notificações", IsSuccess());

            if (!IsSuccess())
                return;

            await _uow.CommitAsync();

            _logger.LogTrace("Is commit database", true);
        }
    }
}
