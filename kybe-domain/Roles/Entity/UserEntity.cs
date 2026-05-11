using kybe_domain.Entity.Abstract;

namespace kybe_domain.Classes.Entity
{
    public sealed class UserEntity : GenericUser
    {
        public UserEntity(){}

        public UserEntity(string name, string phoneNumber, string email)
            : base(name, phoneNumber, email){}
    }
}
