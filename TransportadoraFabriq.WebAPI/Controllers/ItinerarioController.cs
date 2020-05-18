using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Shared.Commands.Interfaces;
using TransportadoraFabriq.Shared.Notification;
using TransportadoraFabriq.WebAPI.Controllers.Base;

namespace TransportadoraFabriq.WebAPI.Controllers
{
    public class ItinerarioController : BaseController
    {
        private readonly IMediator _handle;

        public ItinerarioController(INotificationHandler<NotificationDomain> notifications, IMediator handle) : base(notifications, handle)
        {
            _handle = handle;
        }

        // POST api/values
        [HttpPost("adicionar")]
        public async Task<ICommandResult> Adicionar([FromBody] AdicionarItinerarioCommand adicionarItinerarioCommand)
        {
            var result = await _handle.Send(adicionarItinerarioCommand);

            return Response(result);
        }
    }
}