using kybe_domain.Models.Abstract;

namespace kybe_domain.Interface.IRepository.IAbstract
{
    public interface IAbstractUserRepository<T> : IGenericEntityRepository<T> where T : AbstractUser
    {
    }
}
