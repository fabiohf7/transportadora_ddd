using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Domain.Transporte.Repositories;
using TransportadoraFabriq.Shared.Commands;
using TransportadoraFabriq.Shared.Entities.Interfaces;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Application.Transporte
{
    public class AdicionarItinerarioCommandHandler : CommandHandler, IRequestHandler<AdicionarItinerarioCommand, CommandResult>
    {
        private readonly IItinerarioRepository _itinerarioRepository;

        public AdicionarItinerarioCommandHandler(IItinerarioRepository itinerarioRepository, IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null) : base(uow, mediator, notifications, logger)
        {
            _itinerarioRepository = itinerarioRepository;
        }

        public Task<CommandResult> Handle(AdicionarItinerarioCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
