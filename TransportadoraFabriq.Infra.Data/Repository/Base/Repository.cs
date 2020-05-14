using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TransportadoraFabriq.Infra.Data.Context;

namespace TransportadoraFabriq.Infra.Data.Repository.Base
{
    public abstract class Repository<TDomain> where TDomain : class
    {
        protected readonly AppDbContext _context;

        protected Repository(AppDbContext context)
        {
            _context = context;
        }

        public virtual void Add(TDomain entity)
        {
            _context.Set<TDomain>().Add(entity);
        }

        public virtual async Task AddAsync(TDomain entity)
        {
            await _context.Set<TDomain>().AddAsync(entity);
        }

        public virtual void Remove(TDomain entity)
        {
            _context.Set<TDomain>().Remove(entity);
        }

        public virtual async Task RemoveAsync(TDomain entity)
        {
            await Task.FromResult(_context.Set<TDomain>().Remove(entity));
        }

        public virtual void Update(TDomain entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<TDomain>().Update(entity);
        }

        public async Task UpdateAsync(TDomain entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await Task.FromResult(_context.Set<TDomain>().Update(entity));
        }
    }
}
