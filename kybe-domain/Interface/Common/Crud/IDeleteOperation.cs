using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Abstract.Crud
{
    public interface IDeleteOperation<T> where T : AbstractEntity
    {
        Task DeleteAsync(T entity);
    }
}
