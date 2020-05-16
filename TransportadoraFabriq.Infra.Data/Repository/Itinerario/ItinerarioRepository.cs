using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Domain.Transporte.Repositories;
using TransportadoraFabriq.Infra.Data.Context;
using TransportadoraFabriq.Infra.Data.Repository.Base;

namespace TransportadoraFabriq.Infra.Data.Repository
{
    public class ItinerarioRepository : Repository<Itinerario>, IItinerarioRepository
    {
        private readonly AppDbContext _context;

        public ItinerarioRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Itinerario> ObterPorId(Guid id)
        {
            return null;
            //return await _context.Itinerarios.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
