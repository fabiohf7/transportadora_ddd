using System;
using System.Threading.Tasks;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Domain.Transporte.Repositories;
using TransportadoraFabriq.Infra.Data.Context;
using TransportadoraFabriq.Infra.Data.Repository.Base;

namespace TransportadoraFabriq.Infra.Data.Repository
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        private readonly AppDbContext _context;

        public VeiculoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Motorista> ObterPorId(Guid id)
        {
            return null;
            //return await _context.Itinerarios.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
