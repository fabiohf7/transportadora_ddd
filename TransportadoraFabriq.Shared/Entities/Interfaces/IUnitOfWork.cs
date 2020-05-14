using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransportadoraFabriq.Shared.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();

        Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
