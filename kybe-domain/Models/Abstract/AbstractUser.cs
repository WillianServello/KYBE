using kybe_domain.Common;
using kybe_domain.Models.ValueObject;

namespace kybe_domain.Models.Abstract
{
    public abstract class AbstractUser : AbstractEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string? LastName { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public Address? Address { get; private set; }
        protected AbstractUser() { }
        protected AbstractUser(string name, string? lastName, string phoneNumber, string email, Address? address)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            LastName = lastName;
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
            Address = address;

        }
    }
}
