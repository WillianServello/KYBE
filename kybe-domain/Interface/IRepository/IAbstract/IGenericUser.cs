using kybe_domain.Entity.Abstract;

namespace kybe_domain.Interface.Repository.Abstract
{
    public interface IGenericUser<T> : IGenericEntity<T> where T : GenericUser
    {
    }
}
