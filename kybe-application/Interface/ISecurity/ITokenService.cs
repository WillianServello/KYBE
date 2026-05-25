using kybe_domain.Models.Entity;

namespace kybe_application.Interface.ISecurity
{
    public interface ITokenService
    {
        string GenerateToken(UserEntity user);
    }
}
