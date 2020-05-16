using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Infra.Data.EntityMappingConfig.Base
{
    public class EntityTypeConfigurationBase<TBase> : IEntityTypeConfiguration<TBase> where TBase : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Ignore(x => x.ValidationResult);
            
            builder.Ignore(x => x.Valid);

            builder.Ignore(x => x.Invalid);
        }
    }
}
