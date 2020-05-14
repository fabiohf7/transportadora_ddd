using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TransportadoraFabriq.Shared.Notification
{
    public class NotificationDomainHandler : INotificationHandler<NotificationDomain>
    {
        #region properties

        private List<NotificationDomain> _notifications;

        #endregion

        public NotificationDomainHandler()
        {
            _notifications = new List<NotificationDomain>();
        }

        public Task Handle(NotificationDomain notification, CancellationToken cancellationToken)
        {
            _notifications.Add(notification);

            return Task.CompletedTask;
        }

        public virtual List<NotificationDomain> GetNotifications()
        {
            return _notifications;
        }

        public virtual bool HasNotifications()
        {
            return _notifications.Any();
        }

        public void Dispose()
        {
            _notifications = new List<NotificationDomain>();
        }
    }
}
