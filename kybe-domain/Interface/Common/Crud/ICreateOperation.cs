using kybe_domain.Models.Common.Abstract;
namespace kybe_domain.Interface.Abstract.Crud
{
    public interface ICreateOperation<T> where T : AbstractEntity
    {
        Task AddAsync(T entity);
    }
}
