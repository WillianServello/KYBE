using kybe_application.DTOs.UserDTOs;

namespace kybe_application.Interface.Service.User
{
    public interface IAccountServiceApp
    {
        Task RegisterAsync(RegisterUserDTO dto);
        Task<InformationUserDTO> GetByIdAsync(Guid id);
        Task UpdateAsync(Guid userId, EditUserDTO dto);
        Task DeleteAsync(Guid userId);
    }
}
