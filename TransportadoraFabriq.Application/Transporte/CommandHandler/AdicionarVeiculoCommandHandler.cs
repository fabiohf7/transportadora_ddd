using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Shared.Commands;
using TransportadoraFabriq.Shared.Entities.Interfaces;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Application.Transporte.Handler
{
    public class AdicionarVeiculoCommandHandler : CommandHandler, IRequestHandler<AdicionarVeiculoCommand, CommandResult>
    {
        //private readonly ITransporteRepository _transporteRepository;

        public AdicionarVeiculoCommandHandler(IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null)
        : base(uow, mediator, notifications, logger)
        {
            //_eventoRepository = eventoRepository;
        }

        public Task<CommandResult> Handle(AdicionarVeiculoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
