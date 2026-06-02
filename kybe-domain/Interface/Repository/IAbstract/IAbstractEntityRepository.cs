using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Repository.IAbstract
{
    public interface IAbstractEntityRepository<T> where T : AbstractEntity
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
