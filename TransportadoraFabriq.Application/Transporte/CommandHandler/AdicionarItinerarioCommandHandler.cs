using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Domain.Transporte;
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

        public async Task<CommandResult> Handle(AdicionarItinerarioCommand request, CancellationToken cancellationToken)
        {
            //var new motorista 
            //var new veiculo
            //var itinerario = new Itinerario(request.Motorista, request.Veiculo);

            //await _itinerarioRepository.AddAsync(itinerario);

            //HandleEntity(itinerario);

            if (!IsSuccess())
                return new CommandResult(false, "Existem notificações");

            await CommitAsync();

            return new CommandResult(true, "Executado sem notificações", new {  });
        }
    }
}
