using kybe.infrastructure.Data.Mappings.Abstract;
using kybe_domain.Classes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe.infrastructure.Data.Mappings.Roles
{
    internal class UserMap : AbstractUserMap<UserEntity>
    {
        public override void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            base.Configure(builder);

            builder.ToTable("USERS");
        }
    }
}
