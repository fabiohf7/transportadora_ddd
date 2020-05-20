using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Shared.Commands.Interfaces;
using TransportadoraFabriq.Shared.Notification;
using TransportadoraFabriq.WebAPI.Controllers.Base;

namespace TransportadoraFabriq.WebAPI.Controllers
{
    public class VeiculoController : BaseController
    {
        private readonly IMediator _handle;

        public VeiculoController(INotificationHandler<NotificationDomain> notifications, IMediator handle) : base(notifications, handle)
        {
            _handle = handle;
        }

        // POST api/values
        [HttpPost("adicionar")]
        public async Task<ICommandResult> Adicionar([FromBody] AdicionarVeiculoCommand adicionarVeiculoCommand)
        {
            var result = await _handle.Send(adicionarVeiculoCommand);

            return Response(result);
        }
    }
}