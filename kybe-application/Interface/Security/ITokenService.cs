using kybe_domain.Models.Entity;

namespace kybe_application.Interface.Security
{
    public interface ITokenService
    {
        string GenerateToken(UserEntity user);
    }
}
