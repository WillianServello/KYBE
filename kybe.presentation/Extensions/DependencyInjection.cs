using kybe.infrastructure.Repository.Roles;
using kybe_application.Interface.IService.IUserServoce;
using kybe_application.Roles;
using kybe_domain.Interface.IRepository.IRoles;
using kybe_domain.Interface.Service.IRoles;
using kybe_domain.Service.User;

namespace kybe.presentation.Extensions
{
    internal static class DependencyInjection
    {
        internal static void AddScoped(this IServiceCollection services)
        {
            services.AddScoped<IUserServiceApp, UserAppService>();
            services.AddScoped<IUserServiceDomain, UserDomainService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
