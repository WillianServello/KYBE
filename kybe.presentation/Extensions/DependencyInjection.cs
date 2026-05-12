using kybe.infrastructure.Repository.Roles;
using kybe_domain.Interface.IRepository.IRoles;

namespace kybe.presentation.Extensions
{
    internal static class DependencyInjection
    {
        internal static void AddScoped(this IServiceCollection services)
        {
            services.AddScoped<IUser, UserRepository>();
        }
    }
}
