using kybe.infrastructure.Data.Context;
using kybe.infrastructure.Repository.Abstract;
using kybe_domain.Classes.Entity;
using kybe_domain.Interface.IRepository.IUser;

namespace kybe.infrastructure.Repository.User
{
    public sealed class UserRepository : AbstractUserRepository<UserEntity>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context){}
    }
}
