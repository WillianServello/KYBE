using kybe.infrastructure.Data.Context;
using kybe.infrastructure.Repository.Abstract;
using kybe_domain.Interface.IRepository.IUser;
using kybe_domain.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Repository.User
{
    public sealed class UserRepository : AbstractUserRepository<UserEntity>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context) { }

        public async Task<UserEntity?> GetByUserNameAsync(string userName)
        {
            return await Entity
                .FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
