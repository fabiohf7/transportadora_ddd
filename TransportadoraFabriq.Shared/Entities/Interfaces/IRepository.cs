using System.Threading.Tasks;

namespace TransportadoraFabriq.Shared.Entities.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        Task UpdateAsync(TEntity entity);

        void Remove(TEntity entity);

        Task RemoveAsync(TEntity entity);
    }
}
