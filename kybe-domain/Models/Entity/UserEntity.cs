using kybe_domain.Models.Abstract;
using kybe_domain.Models.ValueObject;

namespace kybe_domain.Models.Entity
{
    public sealed class UserEntity : AbstractUser
    {
        public UserEntity() { }

        public string UserName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;

        public UserEntity(string userName, string password, string name, string lastName, string phoneNumber, string email, string cpf, Address address)
            : base(name, lastName, phoneNumber, email, address)
        {
            UserName = userName;
            Password = password;
        }
    }
}
