using kybe_domain.Entity.Abstract;

namespace kybe_domain.Interface.Repository.Abstract
{
    public interface IGenericUserRepository<T> : IGenericEntityRepository<T> where T : AbstractUser
    {
    }
}
