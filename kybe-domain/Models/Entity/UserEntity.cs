using kybe_domain.Models.Common.Abstract;
using kybe_domain.Models.Common.ValueObject;

namespace kybe_domain.Models.Entity
{
    public sealed class UserEntity : AbstractPerson
    {
        public UserEntity() { }

        public string UserName { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = null!;

        public UserEntity(string userName, string password, string name, string lastName, string phoneNumber, string email, string cpf, Address address)
            : base(name, lastName, phoneNumber, email, cpf, address)
        {
            UserName = userName;
            PasswordHash = password;
        }

        public void UpdateUser(string userName, string name, string lastName, string phoneNumber, string email, string cpf)
        {
            UserName = userName;

            UpdateBasicData(name, lastName, phoneNumber, email, cpf);
        }
    }
}
