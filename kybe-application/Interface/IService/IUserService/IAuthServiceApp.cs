using kybe_application.DTOs.AuthDTOs;

namespace kybe_application.Interface.IService.IUserService
{
    public interface IAuthServiceApp
    {
        Task<string?> LoginAsync(LoginUser dto);
    }
}
