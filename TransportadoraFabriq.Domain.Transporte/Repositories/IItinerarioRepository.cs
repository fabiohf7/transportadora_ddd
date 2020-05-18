using System;
using System.Threading.Tasks;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.Domain.Transporte.Repositories
{
    public interface IItinerarioRepository : IRepository<Itinerario>
    {
        Task<Itinerario> ObterPorId(Guid id);
    }
}
