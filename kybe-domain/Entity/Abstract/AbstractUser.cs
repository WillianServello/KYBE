using kybe_domain.Common;
using kybe_domain.Entity.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe_domain.Entity.Abstract
{
    public abstract class AbstractUser : AbstractEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string PhoneNumber{ get; private set; } = string.Empty;
        public string Email{ get; private set; } = string.Empty;

        public Address? Address{ get; private set; }
        protected AbstractUser() { }
        protected AbstractUser(string name, string phoneNumber, string email)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
        }
    }
}
