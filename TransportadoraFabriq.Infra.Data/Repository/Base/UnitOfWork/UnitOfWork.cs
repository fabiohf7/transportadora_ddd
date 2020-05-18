using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportadoraFabriq.Infra.Data.Context;
using TransportadoraFabriq.Shared.Entities.Interfaces;

namespace TransportadoraFabriq.Infra.Data.Repository.Base.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        private readonly IMediator _mediator;
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(AppDbContext context, IMediator mediator, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _mediator = mediator;
            _logger = logger;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(_context, _logger);

            var result = await _context.SaveChangesAsync();

            _logger.LogTrace("Is CommitAsync DataBase Results", result);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
