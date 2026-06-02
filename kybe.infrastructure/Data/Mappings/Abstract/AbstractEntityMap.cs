using kybe_domain.Models.Common.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kybe.infrastructure.Data.Mappings.Abstract
{
    internal abstract class AbstractEntityMap<T> : IEntityTypeConfiguration<T> where T : AbstractEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder
                .Property(x => x.CreateAt)
                .HasColumnName("CREATE_AT")
                .IsRequired();

            builder
                .Property(x => x.UpdateAt)
                .HasColumnName("UPDATE_AT")
                .IsRequired(false);

            builder
                .Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE")
                .IsRequired();
        }
    }
}
