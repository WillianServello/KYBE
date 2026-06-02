using kybe_domain.Models.Common.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kybe.infrastructure.Data.Mappings.Abstract
{
    internal abstract class AbstractUserMap<T> : AbstractEntityMap<T> where T : AbstractUser
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
                .Property(x => x.LastName)
                .HasMaxLength(128)
                .HasColumnName("LAST_NAME");

            builder
                .Property(x => x.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("PHONE_NUMBER")
                .IsRequired();
            builder
                .Property(x => x.Cpf)
                .HasMaxLength(20)
                .HasColumnName("CPF")
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
