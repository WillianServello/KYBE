using kybe_application.DTOs.SharedDTOs;

namespace kybe_application.DTOs.UserDTOs
{
    public class RegisterUser
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public AddressDTO? AddressDTO { get; set; } = new AddressDTO();
    }
}
