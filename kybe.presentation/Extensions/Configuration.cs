using kybe.infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace kybe.presentation.Extensions;

public static class Configuration
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DatabaseContext>(options =>
            options.UseMySQL(configuration.GetConnectionString("Database")!));

        return services;
    }
}