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
using static TransportadoraFabriq.Application.Transporte.Command.AdicionarItinerarioCommand;

namespace TransportadoraFabriq.Application.Transporte
{
    public class AdicionarItinerarioCommandHandler : CommandHandler, IRequestHandler<AdicionarItinerarioCommand, CommandResult>
    {
        private readonly IItinerarioRepository _itinerarioRepository;
        private readonly IMotoristaRepository _motoristaRepository;
        private readonly IVeiculoRepository _veiculoRepository;

        public AdicionarItinerarioCommandHandler(IVeiculoRepository veiculoRepository , IItinerarioRepository itinerarioRepository, IMotoristaRepository motoristaRepository, IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null) : base(uow, mediator, notifications, logger)
        {
            _itinerarioRepository = itinerarioRepository;
            _motoristaRepository = motoristaRepository;
            _veiculoRepository = veiculoRepository;
        }

        public async Task<CommandResult> Handle(AdicionarItinerarioCommand request, CancellationToken cancellationToken)
        {
            var motorista = await _motoristaRepository.ObterPorId(request.MotoristaId);

            if (motorista == null)
                AddNotification("Motorista", "Motorista não encontrado.");

            var veiculo = await _veiculoRepository.ObterPorId(request.VeiculoId);

            if (veiculo == null)
                AddNotification("Veículo", "Veículo não encontrado.");

            var itinerario = new Itinerario(motorista, veiculo);
            await _itinerarioRepository.AddAsync(itinerario);

            GerarEntregasNoItinerario(request.Entregas, itinerario);

            HandleEntity(itinerario);

            if (!IsSuccess())
                return new CommandResult(false, "Existem notificações");

            await CommitAsync();

            return new CommandResult(true, "Executado sem notificações", new {  });
        }

        private void GerarEntregasNoItinerario(List<EntregaCommand> entregas, Itinerario itinerario)
        {
            foreach (var item in entregas)
            {
                itinerario.AdicionarEntrega(item.Destinatario.Nome, item.Destinatario.Endereco, DateTime.Now);
            }
        }
    }
}
