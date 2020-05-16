using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class ItinerarioConfiguration : AggregateRootTypeConfigurationBase<Itinerario>
    {
        public override void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Itinerario");

            builder.HasOne(x => x.Motorista);

            builder.HasOne(x => x.Veiculo);

            builder.HasMany(x => x.Entregas).WithOne(x => x.Itinerario).IsRequired();
        }
    }
}
