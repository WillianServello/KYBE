using kybe_domain.Models.Abstract;

namespace kybe_domain.Interface.IRepository.IAbstract
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
