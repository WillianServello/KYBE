using kybe_application.DTOs.CommonDTOs;
using kybe_domain.Models.Common.Enum;

namespace kybe_application.DTOs.AccountDTOs
{
    public sealed class AccountUpdateDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public AddressDTO? AddressDTO { get; set; }
        public ProfileEnum Profile { get; set; }
    }
}
