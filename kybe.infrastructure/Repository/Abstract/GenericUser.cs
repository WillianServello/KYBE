using kybe.infrastructure.Data.Context;
using kybe_domain.Entity.Abstract;
using kybe_domain.Interface.Repository.Abstract;

namespace kybe.infrastructure.Repository.Abstract
{
    public abstract class GenericUser<T> : GenericEntity<T>, IGenericUser<T> where T : GenericUser
    {
        protected GenericUser(DatabaseContext context) : base(context){}
    }
}
