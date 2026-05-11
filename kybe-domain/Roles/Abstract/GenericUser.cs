using kybe_domain.Common;
using kybe_domain.Entity.ValueObject;

namespace kybe_domain.Entity.Abstract
{
    public abstract class GenericUser : GenericEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string PhoneNumber{ get; private set; } = string.Empty;
        public string Email{ get; private set; } = string.Empty;

        public Address? Address{ get; private set; }
        protected GenericUser() { }
        protected GenericUser(string name, string phoneNumber, string email)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
        }
    }
}
