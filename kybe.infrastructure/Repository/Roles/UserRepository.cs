using kybe.infrastructure.Data.Context;
using kybe.infrastructure.Repository.Abstract;
using kybe_domain.Classes.Entity;
using kybe_domain.Interface.IRepository.IRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe.infrastructure.Repository.Roles
{
    public sealed class UserRepository : GenericUser<UserEntity>, IUser
    {
        public UserRepository(DatabaseContext context) : base(context){}
    }
}
