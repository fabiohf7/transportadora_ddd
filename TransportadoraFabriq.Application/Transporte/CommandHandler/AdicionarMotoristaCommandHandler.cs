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
    public class AdicionarMotoristaCommandHandler : CommandHandler, IRequestHandler<AdicionarMotoristaCommand, CommandResult>
    {
        private readonly IMotoristaRepository _motoristaRepository;

        public AdicionarMotoristaCommandHandler(IMotoristaRepository motoristaRepository, IUnitOfWork uow, IMediator mediator, INotificationHandler<NotificationDomain> notifications, ILogger<CommandHandler> logger = null) : base(uow, mediator, notifications, logger)
        {
            _motoristaRepository = motoristaRepository;
        }

        public async Task<CommandResult> Handle(AdicionarMotoristaCommand request, CancellationToken cancellationToken)
        {
            var cnhMotorista = new CNH(request.NumeroDeRegistroCnh, request.DataValidadeCnh);           

            var motorista = new Motorista(request.Nome, request.Sobrenome, cnhMotorista, request.DataNascimento);

            await _motoristaRepository.AddAsync(motorista);

            HandleEntity(motorista);

            if (!IsSuccess())
                return new CommandResult(false, "Existem notificações");

            await CommitAsync();

            return new CommandResult(true, "Executado sem notificações", new { motorista.Id });
        }
    }
}
