using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Application.Transporte.Command;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Domain.Transporte.Repositories;
using TransportadoraFabriq.Domain.Transporte.ValueObjects;
using TransportadoraFabriq.Shared.Commands;
using TransportadoraFabriq.Shared.Entities.Interfaces;
using TransportadoraFabriq.Shared.Notification;

namespace TransportadoraFabriq.Application.Transporte
{
    public class AdicionarVeiculoCommandHandler : CommandHandler, IRequestHandler<AdicionarVeiculoCommand, CommandResult>
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public AdicionarVeiculoCommandHandler(IVeiculoRepository veiculoRepository, IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null) : base(uow, mediator, notifications, logger)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<CommandResult> Handle(AdicionarVeiculoCommand request, CancellationToken cancellationToken)
        {
            var crlvVeiculo = new CRLV(request.Placa, request.Renavam, request.Chassi,request.Marca);

            var veiculo = new Veiculo(crlvVeiculo, request.CapacidadeCarga, request.Refrigerado);

            await _veiculoRepository.AddAsync(veiculo);

            HandleEntity(veiculo);

            if (!IsSuccess())
                return new CommandResult(false, "Existem notificações");

            await CommitAsync();

            return new CommandResult(true, "Executado sem notificações", new { veiculo.Id });
        }
    }
}
