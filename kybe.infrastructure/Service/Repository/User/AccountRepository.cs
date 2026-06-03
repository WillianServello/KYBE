using kybe.infrastructure.Data.Context;
using kybe.infrastructure.Service.Abstract;
using kybe_domain.Interface.Repository.User;
using kybe_domain.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Service.Repository.User
{
    public sealed class AccountRepository : CrudContract<UserEntity>, IAccountRepository
    {
        public AccountRepository(DatabaseContext context) : base(context) { }

        public async Task<UserEntity?> GetByUserNameAsync(string userName)
        {
            return await Entity
                .FirstOrDefaultAsync(x => x.UserName == userName && x.IsActive == true);
        }
    }
}
