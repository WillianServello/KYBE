using kybe.infrastructure.Data.Context;
using kybe.infrastructure.Service.Repository.Abstract;
using kybe_domain.Interface.Repository.IUser;
using kybe_domain.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Service.Repository.User
{
    public sealed class AccountRepository : AbstractUserRepository<UserEntity>, IAccountRepository
    {
        public AccountRepository(DatabaseContext context) : base(context) { }

        public async Task<UserEntity?> GetByUserNameAsync(string userName)
        {
            return await Entity
                .FirstOrDefaultAsync(x => x.UserName == userName && x.IsActive == true);
        }
    }
}
