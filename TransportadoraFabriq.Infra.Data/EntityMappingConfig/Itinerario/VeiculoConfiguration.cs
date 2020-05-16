using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class VeiculoConfiguration : EntityTypeConfigurationBase<Veiculo>
    {
        public override void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            base.Configure(builder);

            builder.ToTable("Veiculo");

            builder.OwnsOne(x => x.CRLV)
                .Property(x => x.Marca)
                .HasColumnName("Marca");

            builder.OwnsOne(x => x.CRLV)
               .Property(x => x.Placa)
               .HasColumnName("Placa");

            builder.OwnsOne(x => x.CRLV)
               .Property(x => x.Renavam)
               .HasColumnName("Renavam");

            builder.OwnsOne(x => x.CRLV)
               .Property(x => x.Chassi)
               .HasColumnName("Chassi");
        }
    }
}
