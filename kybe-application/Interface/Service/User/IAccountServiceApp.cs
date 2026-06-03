using kybe_application.DTOs.AccountDTOs;
using kybe_application.Interface.Service.Abstract.Crud;

namespace kybe_application.Interface.Service.User
{
    public interface IAccountServiceApp : ICrudServiceApp<AccountDetailsDTO, AccountUpdateDTO, AccountCreateDTO>
    {
        Task<List<AccountAuditLogDTO>> GetAllUserNamesAsync();

    }
}
