using kybe_domain.Interface.Abstract.Crud;
using kybe_domain.Models.Entity;

namespace kybe_domain.Interface.Service.User
{
    public interface IAccountServiceDomain : ICrudContract<UserEntity>
    {
        Task<UserEntity?> GetByUserNameAsync(string userName);
    }
}
