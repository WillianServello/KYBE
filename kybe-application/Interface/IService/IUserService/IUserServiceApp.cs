using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.IService.IUserServoce
{
    public interface IUserServiceApp
    {
        Task RegisterAsync(RegisterUser dto);
    }
}
