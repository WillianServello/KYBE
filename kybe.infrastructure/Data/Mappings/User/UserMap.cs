using kybe.infrastructure.Data.Mappings.Abstract;
using kybe_domain.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace kybe.infrastructure.Data.Mappings.User
{
    internal class UserMap : AbstractUserMap<UserEntity>
    {
        public override void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            base.Configure(builder);

            builder.ToTable("USERS");

            builder
                .Property(x => x.UserName)
                .HasColumnName("USER_NAME")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.PasswordHash)
                .HasColumnName("PASSWORD")
                .HasMaxLength(255)
                .IsRequired();

        }
    }
}
