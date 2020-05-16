using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig;

namespace TransportadoraFabriq.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Itinerario> Itinerarios { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Entrega> Entrega { get; set; }
        public DbSet<Comprovante> Comprovantes { get; set; }
        public DbSet<Destinatario> Destinatarios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected AppDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ModelConfiguration
            AddModelConfiguration(modelBuilder);
        }

        private void AddModelConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItinerarioConfiguration());
            modelBuilder.ApplyConfiguration(new EntregaConfiguration());
            modelBuilder.ApplyConfiguration(new MotoristaConfiguration());
            modelBuilder.ApplyConfiguration(new VeiculoConfiguration());
            modelBuilder.ApplyConfiguration(new DestinatarioConfiguration());
            modelBuilder.ApplyConfiguration(new ComprovanteConfiguration());
        }
    }
}
