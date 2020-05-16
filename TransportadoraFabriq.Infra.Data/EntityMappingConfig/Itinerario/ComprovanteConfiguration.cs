using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class ComprovanteConfiguration : EntityTypeConfigurationBase<Comprovante>
    {
        public override void Configure(EntityTypeBuilder<Comprovante> builder)
        {
            base.Configure(builder);

            builder.ToTable("Comprovante");

            builder.HasOne(x => x.Entrega).WithOne(x => x.Comprovate).IsRequired();
        }
    }
}
