using kybe_domain.Interface.Abstract.Crud;
using kybe_domain.Models.Entity;

namespace kybe_domain.Interface.Repository.User
{
    public interface IAccountRepository : ICrudContract<UserEntity>
    {
        Task<UserEntity?> GetByUserNameAsync(string userName);
    }
}
