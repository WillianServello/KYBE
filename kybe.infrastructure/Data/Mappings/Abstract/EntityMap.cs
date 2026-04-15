using kybe_domain.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe.infrastructure.Data.Mappings.Abstract
{
    internal abstract class EntityMap<T> : IEntityTypeConfiguration<T> where T : AbstractEntity
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
                .IsRequired();

            builder
                .Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE")
                .IsRequired();
        }
    }
}
