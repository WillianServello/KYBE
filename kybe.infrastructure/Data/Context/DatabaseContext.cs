using kybe.infrastructure.Data.Mappings.Roles;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Data.Context
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            ApplyMigrations();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserMap());
        }

        private void ApplyMigrations()
        {
            Database.GetPendingMigrations().Any();
            Database.Migrate();
        }
    }
}
