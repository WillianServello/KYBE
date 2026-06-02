using kybe_domain.Models.Entity;

namespace kybe_domain.Interface.Service.User
{
    public interface IAccountServiceDomain
    {
        Task<ICollection<UserEntity>> GetAllAsync();
        Task<UserEntity> GetByIdAsync(Guid id);
        Task AddAsync(UserEntity entity);
        Task UpdateAsync(UserEntity entity);
        Task DeleteAsync(UserEntity entity);
        Task<UserEntity?> GetByUserNameAsync(string userName);
    }
}
