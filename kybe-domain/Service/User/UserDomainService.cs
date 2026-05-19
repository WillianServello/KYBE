using kybe_domain.Interface.IRepository.IUser;
using kybe_domain.Interface.IService.IUser;
using kybe_domain.Models.Entity;

namespace kybe_domain.Service.User
{
    public class UserDomainService : IUserServiceDomain
    {
        private readonly IUserRepository _userRepository;

        public UserDomainService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task AddAsync(UserEntity entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public Task DeleteAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<UserEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
