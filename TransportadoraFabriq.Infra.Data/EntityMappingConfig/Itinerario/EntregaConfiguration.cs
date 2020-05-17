using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class EntregaConfiguration : EntityTypeConfigurationBase<Entrega>
    {
        public override void Configure(EntityTypeBuilder<Entrega> builder)
        {
            base.Configure(builder);

            builder.ToTable("Entrega");

            builder.HasOne(x => x.Destinatario).WithOne().IsRequired();

            builder.HasOne(x => x.Comprovate).WithOne();

            builder.HasOne(x => x.Itinerario).WithMany(x => x.Entregas).IsRequired();
        }
    }
}
