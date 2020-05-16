using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base
{
    public class AggregateRootTypeConfigurationBase<TBase> : EntityTypeConfigurationBase<TBase> where TBase : AggregateRoot
    {
        public override void Configure(EntityTypeBuilder<TBase> builder)
        {
            base.Configure(builder);
        }
    }
}
