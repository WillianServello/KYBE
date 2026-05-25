using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.IService.IUserService
{
    public interface IAuthServiceApp
    {
        Task<string?> LoginAsync(LoginUser dto);
    }
}
