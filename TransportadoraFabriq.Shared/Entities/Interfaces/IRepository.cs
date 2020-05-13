using System.Threading.Tasks;

namespace TransportadoraFabriq.Shared.Entities.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);

        Task AddAsync(T entity);

        void Update(T entity);

        Task UpdateAsync(T entity);

        void Delete(T entity);

        Task DeleteAsync(T entity);
    }
}
