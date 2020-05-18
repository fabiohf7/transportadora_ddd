using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Commands;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.WebAPI.Controllers.Base
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BaseController : Controller
    {
        protected readonly NotificationDomainHandler _notifications;
        private readonly IMediator _handle;


        public BaseController(INotificationHandler<NotificationDomain> notifications,
                                 IMediator handle)
        {

            _notifications = (NotificationDomainHandler)notifications;
            _handle = handle;
        }

        protected new CommandResult Response(CommandResult result = null)
        {
            if (OperacaoEhValida())
            {
                return result;
            }

            return new CommandResult(false, string.Empty, _notifications.GetNotifications());
        }

        protected bool OperacaoEhValida()
        {
            return (!_notifications.HasNotifications());
        }

        protected void NotificarErro(string codigo, string mensagem)
        {
            _handle.Publish(new NotificationDomain(codigo, mensagem));
        }

        protected void AdicionarErrosIdentity(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotificarErro(result.ToString(), error.Description);
            }
        }
    }
}
