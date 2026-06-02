using kybe.infrastructure.Service.Repository.User;
using kybe.infrastructure.Service.Security;
using kybe_application.Interface.Security;
using kybe_application.Interface.Service.User;
using kybe_application.Service.User;
using kybe_domain.Interface.Repository.IUser;
using kybe_domain.Interface.Service.User;
using kybe_domain.Service.User;

namespace kybe.presentation.Extensions
{
    internal static class DependencyInjection
    {
        internal static void AddScoped(this IServiceCollection services)
        {
            services.AddScoped<IAccountServiceApp, AccountServiceApp>();
            services.AddScoped<IAccountServiceDomain, AccountDomainService>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuthServiceApp, AuthServiceApp>();
        }
    }
}
