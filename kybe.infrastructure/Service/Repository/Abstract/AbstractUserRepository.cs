using kybe.infrastructure.Data.Context;
using kybe_domain.Interface.Repository.IAbstract;
using kybe_domain.Models.Common.Abstract;

namespace kybe.infrastructure.Service.Repository.Abstract
{
    public abstract class AbstractUserRepository<T> : AbstractEntityRepository<T>, IAbstractUserRepository<T> where T : AbstractUser
    {
        protected AbstractUserRepository(DatabaseContext context) : base(context) { }
    }
}
