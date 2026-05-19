using kybe_domain.Entity.Abstract;

namespace kybe_domain.Interface.Repository.Abstract
{
    public interface IAbstractUserRepository<T> : IGenericEntityRepository<T> where T : AbstractUser
    {
    }
}
