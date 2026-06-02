using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Repository.IAbstract
{
    public interface IAbstractUserRepository<T> : IAbstractEntityRepository<T> where T : AbstractUser
    {
    }
}
