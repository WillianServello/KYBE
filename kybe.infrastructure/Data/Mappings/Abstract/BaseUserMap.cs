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
    internal abstract class BaseUserMap<T> : BaseEntityMap<T> where T : AbstractUser
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

            builder.OwnsOne(x => x.Address, address =>
            {

                address
                    .Property(a => a.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(128);

                address
                    .Property(a => a.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(128);

                address
                    .Property(a => a.Neighborhood)
                    .HasColumnName("NEIGHBORHOOD")
                    .HasMaxLength(128);

                address
                    .Property(a => a.Number)
                    .HasColumnName("NUMBER")
                    .HasMaxLength(10);

                address
                    .Property(a => a.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(20);

                address
                    .Property(a => a.ZipCode)
                    .HasColumnName("ZIPCODE")
                    .HasMaxLength(20);

                address
                    .Property(a => a.Complementary)
                    .HasColumnName("COMPLEMENT")
                    .HasMaxLength(128);
            });

            builder
                .Property(x => x.Email)
                .HasMaxLength(256)
                .HasColumnName("EMAIL")
                .IsRequired();
        }
    }
}
