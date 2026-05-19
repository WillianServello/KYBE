using kybe.infrastructure.Repository.User;
using kybe_application.Interface.IService.IUserService;
using kybe_application.Service;
using kybe_domain.Interface.IRepository.IUser;
using kybe_domain.Interface.IService.IUser;
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
