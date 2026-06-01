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
        public string Cpf { get; private set; } = string.Empty;

        public Address? Address { get; private set; }
        protected AbstractUser() { }
        protected AbstractUser(string name, string? lastName, string phoneNumber, string email, string cpf, Address? address)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            LastName = lastName;
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
            Cpf = Guard.AgainstNullOrWhiteSpace(cpf, nameof(Cpf));
            Address = address;

        }

        public void UpdateBasicData(string name, string? lastName, string phoneNumber, string email, string cpf)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            LastName = lastName;
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
            Cpf = Guard.AgainstNullOrWhiteSpace(cpf, nameof(Cpf));
        }
    }
}
