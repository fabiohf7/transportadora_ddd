using MediatR;

namespace TransportadoraFabriq.Shared.Commands.Interfaces
{
    public interface ICommand : IRequest<CommandResult>
    {
    }}
}
