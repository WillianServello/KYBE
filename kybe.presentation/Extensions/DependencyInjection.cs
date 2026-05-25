using kybe.infrastructure.Repository.User;
using kybe.infrastructure.Security;
using kybe_application.Interface.ISecurity;
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
            services.AddScoped<IUserServiceApp, UserServiceApp>();
            services.AddScoped<IUserServiceDomain, UserDomainService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuthServiceApp, AuthServiceApp>();
        }
    }
}
