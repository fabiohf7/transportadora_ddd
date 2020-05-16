using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig
{
    public class DestinatarioConfiguration : EntityTypeConfigurationBase<Destinatario>
    {
        public override void Configure(EntityTypeBuilder<Destinatario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Destinatario");

            builder.HasOne(x => x.Entrega).WithOne(x => x.Destinatario).IsRequired();
        }
    }
}
