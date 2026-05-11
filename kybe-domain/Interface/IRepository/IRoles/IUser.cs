using kybe_domain.Classes.Entity;
using kybe_domain.Interface.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe_domain.Interface.IRepository.IRoles
{
    public interface IUser : IGenericUser<UserEntity>
    { 
    }
}
