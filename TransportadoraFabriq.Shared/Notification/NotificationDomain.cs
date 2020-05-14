using MediatR;
using System;

namespace TransportadoraFabriq.Shared.Notification
{
    public class NotificationDomain : INotification
    {
        #region 

        public DateTimeOffset Timestamp { get; private set; }

        public string MessageId { get; private set; }

        public string Message { get; private set; }

        #endregion

        #region construtor

        public NotificationDomain(string message)
        {
            Message = message;
        }

        public NotificationDomain(string messageId, string message)
        {
            MessageId = messageId;
            Message = message;
        }

        #endregion
    }
}
