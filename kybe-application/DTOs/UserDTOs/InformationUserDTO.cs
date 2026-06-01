using kybe_application.DTOs.CommonDTOs;
namespace kybe_application.DTOs.UserDTOs
{
    public sealed class InformationUserDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public AddressDTO? AddressDTO { get; set; } 
    }
}
