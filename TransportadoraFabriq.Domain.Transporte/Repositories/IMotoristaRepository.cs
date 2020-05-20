using System;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.Domain.Transporte.Repositories
{
    public interface IMotoristaRepository : IRepository<Motorista>
    {
        Task<Motorista> ObterPorId(Guid id);
    }
}
