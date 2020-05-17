using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class MotoristaConfiguration : EntityTypeConfigurationBase<Motorista>
    {
        public override void Configure(EntityTypeBuilder<Motorista> builder)
        {
            base.Configure(builder);

            builder.ToTable("Motorista");

            builder.OwnsOne(x => x.CNH)
                .Property(x => x.DataValidade)
                .HasColumnName("ValidadeCnh");

            builder.OwnsOne(x => x.CNH)
               .Property(x => x.NumeroDeRegistro)
               .HasColumnName("RegistroCnh");
        }
    }
}
