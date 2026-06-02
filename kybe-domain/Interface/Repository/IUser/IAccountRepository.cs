using kybe_domain.Interface.Repository.IAbstract;
using kybe_domain.Models.Entity;

namespace kybe_domain.Interface.Repository.IUser
{
    public interface IAccountRepository : IAbstractUserRepository<UserEntity>
    {
        Task<UserEntity?> GetByUserNameAsync(string userName);
    }
}
