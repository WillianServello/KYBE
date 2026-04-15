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
    internal abstract class UserMap<T> : EntityMap<T> where T : AbstractUser
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.Name)
                .HasMaxLength(128)
                .HasColumnName("NAME")
                .IsRequired();

            builder
                .Property(x => x.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("PHONE_NUMBER")
                .IsRequired();

            builder
                .Property(x => x.Email)
                .HasMaxLength(256)
                .HasColumnName("EMAIL")
                .IsRequired();
        }
    }
}
