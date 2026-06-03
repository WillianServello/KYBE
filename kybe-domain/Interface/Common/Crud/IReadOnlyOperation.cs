using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Abstract.Crud
{
    public interface IReadOnlyOperation<T> where T : AbstractEntity
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
    }
}
