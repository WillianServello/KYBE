using kybe_domain.Classes.Entity;

namespace kybe_domain.Interface.Service.IRoles
{
    public interface IUserServiceDomain
    {
        Task<ICollection<UserEntity>> GetAllAsync();
        Task<UserEntity> GetByIdAsync(Guid id);
        Task AddAsync(UserEntity entity);
        Task UpdateAsync(UserEntity entity);
        Task DeleteAsync(UserEntity entity);
    }
}
