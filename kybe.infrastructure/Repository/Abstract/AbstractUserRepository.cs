using kybe.infrastructure.Data.Context;
using kybe_domain.Entity.Abstract;
using kybe_domain.Interface.Repository.Abstract;

namespace kybe.infrastructure.Repository.Abstract
{
    public abstract class AbstractUserRepository<T> : AbstractEntityRepository<T>, IGenericUserRepository<T> where T : AbstractUser
    {
        protected AbstractUserRepository(DatabaseContext context) : base(context){}
    }
}
