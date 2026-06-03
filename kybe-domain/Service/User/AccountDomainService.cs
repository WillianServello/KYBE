using kybe_domain.Interface.Repository.User;
using kybe_domain.Interface.Service.User;
using kybe_domain.Models.Entity;

namespace kybe_domain.Service.User
{
    public class AccountDomainService : IAccountServiceDomain
    {
        private readonly IAccountRepository _userRepository;

        public AccountDomainService(IAccountRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task AddAsync(UserEntity entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(UserEntity entity)
        {
            entity.SetInactive();
            await _userRepository.DeleteAsync(entity);
        }

        public async Task<ICollection<UserEntity>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public Task<List<string>> GetAllUserNamesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> GetByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public Task<UserEntity?> GetByUserNameAsync(string userName)
        {
            return _userRepository.GetByUserNameAsync(userName);
        }

        public async Task UpdateAsync(UserEntity entity)
        {
            await _userRepository.UpdateAsync(entity);
        }
    }
}
