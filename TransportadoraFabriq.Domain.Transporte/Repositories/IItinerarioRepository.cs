using System;
using System.Threading.Tasks;

namespace TransportadoraFabriq.Domain.Transporte.Repositories
{
    public interface IItinerarioRepository
    {
        Task<Itinerario> ObterPorId(Guid id);
    }
}
