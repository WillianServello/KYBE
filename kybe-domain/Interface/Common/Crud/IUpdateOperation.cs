using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Abstract.Crud
{
    public interface IUpdateOperation<T> where T : AbstractEntity
    {
        Task UpdateAsync(T entity);
    }
}
