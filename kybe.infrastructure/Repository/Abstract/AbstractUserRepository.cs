using kybe.infrastructure.Data.Context;
using kybe_domain.Interface.IRepository.IAbstract;
using kybe_domain.Models.Abstract;

namespace kybe.infrastructure.Repository.Abstract
{
    public abstract class AbstractUserRepository<T> : AbstractEntityRepository<T>, IAbstractUserRepository<T> where T : AbstractUser
    {
        protected AbstractUserRepository(DatabaseContext context) : base(context) { }
    }
}
