using kybe_domain.Classes.Entity;
using kybe_domain.Interface.IRepository.IRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe_application.Roles
{
    public sealed class UserService : IUser
    {
        public Task AddAsync(UserEntity entity)
        {
            throw new NotImplementedException();
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
