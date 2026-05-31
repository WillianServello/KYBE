using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.IService.IUserService
{
    public interface IUserServiceApp
    {
        Task RegisterAsync(RegisterUserDTO dto);

        Task<UserDetailsDTO> GetByIdAsync(Guid id);
    }
}
