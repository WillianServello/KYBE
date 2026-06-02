using kybe_application.DTOs.AuthDTOs;
using kybe_application.Interface.Security;
using kybe_application.Interface.Service.User;
using kybe_domain.Interface.Service.User;

namespace kybe_application.Service.User
{
    public sealed class AuthServiceApp : IAuthServiceApp
    {
        private readonly IAccountServiceDomain _userServiceDomain;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;

        public AuthServiceApp(IAccountServiceDomain userServiceDomain, IPasswordHasher passwordHasher, ITokenService tokenService)
        {
            _userServiceDomain = userServiceDomain;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
        }
        public async Task<string?> LoginAsync(LoginUser dto)
        {
            var user = await _userServiceDomain.GetByUserNameAsync(dto.UserName);

            if (user is null)
                return null;

            var passwordIsValid = _passwordHasher.Verify(dto.Password, user.PasswordHash);

            if (!passwordIsValid)
                return null;

            var token = _tokenService.GenerateToken(user);

            return token;
        }
    }
}
