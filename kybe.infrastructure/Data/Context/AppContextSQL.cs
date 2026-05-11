using kybe.infrastructure.Data.Mappings.Roles;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Data.Context
{
    internal sealed class AppContextSQL : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserMap());
        }
    }
}
