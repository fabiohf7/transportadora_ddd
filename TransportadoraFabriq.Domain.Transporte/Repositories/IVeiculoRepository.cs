using System;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.Domain.Transporte.Repositories
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<Veiculo> ObterPorId(Guid id);
    }
}
