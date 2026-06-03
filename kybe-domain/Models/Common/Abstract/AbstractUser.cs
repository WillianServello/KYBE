using kybe_domain.Models.Common.Enum;
using kybe_domain.Models.Common.Validation;
using kybe_domain.Models.Common.ValueObject;

namespace kybe_domain.Models.Common.Abstract
{
    public abstract class AbstractUser : AbstractEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string? LastName { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Cpf { get; private set; } = string.Empty;
        public ProfileEnum Profile { get; private set; } = ProfileEnum.User;
        public Address? Address { get; private set; }
        protected AbstractUser() { }
        protected AbstractUser(string name, string? lastName, string phoneNumber, string email, string cpf,  Address? address)
        {
            Name = Guard.AgainstNullOrWhiteSpace(name, nameof(Name));
            LastName = lastName;
            PhoneNumber = Guard.AgainstNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber));
            Email = Guard.AgainstNullOrWhiteSpace(email, nameof(Email));
            Cpf = Guard.AgainstNullOrWhiteSpace(cpf, nameof(Cpf));
            Profile = ProfileEnum.User;
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
