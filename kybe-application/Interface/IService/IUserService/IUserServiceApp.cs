using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.IService.IUserService
{
    public interface IUserServiceApp
    {
        Task RegisterAsync(RegisterUserDTO dto);
        Task<InformationUserDTO> GetByIdAsync(Guid id);
        Task UpdateAsync(Guid userId, EditUserDTO dto);
    }
}
