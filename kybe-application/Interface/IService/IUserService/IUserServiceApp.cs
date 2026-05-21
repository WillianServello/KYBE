using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.IService.IUserService
{
    public interface IUserServiceApp
    {
        Task RegisterAsync(RegisterUser dto);
        Task LoginAsync(LoginUser dto);
    }
}
