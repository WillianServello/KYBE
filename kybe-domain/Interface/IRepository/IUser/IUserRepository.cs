using kybe_domain.Interface.IRepository.IAbstract;
using kybe_domain.Models.Entity;

namespace kybe_domain.Interface.IRepository.IUser
{
    public interface IUserRepository : IAbstractUserRepository<UserEntity>
    {
    }
}
