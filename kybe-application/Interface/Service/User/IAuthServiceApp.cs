using kybe_application.DTOs.AuthDTOs;

namespace kybe_application.Interface.Service.User
{
    public interface IAuthServiceApp
    {
        Task<string?> LoginAsync(LoginUser dto);
    }
}
