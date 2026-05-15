using kybe_domain.Entity.Abstract;

namespace kybe_domain.Interface.Repository.Abstract
{
    public interface IGenericEntityRepository<T> where T : AbstractEntity
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
