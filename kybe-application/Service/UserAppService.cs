using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserServoce;
using kybe_domain.Classes.Entity;
using kybe_domain.Entity.ValueObject;
using kybe_domain.Interface.IRepository.IRoles;
using kybe_domain.Interface.Service.IRoles;


namespace kybe_application.Roles
{
    public sealed class UserAppService : IUserServiceApp
    {
        private readonly IUserServiceDomain _userServiceDomain;

        public UserAppService(IUserServiceDomain userServiceDomain)
        {
            _userServiceDomain = userServiceDomain;
        }

        public Task RegisterAsync(RegisterUser dto)
        {
            Address? address = null;

            if (dto.AddressDTO is not null)
            {
                address = new Address(
                    dto.AddressDTO.Street,
                    dto.AddressDTO.Number,
                    dto.AddressDTO.Complementary,
                    dto.AddressDTO.Neighborhood,
                    dto.AddressDTO.City,
                    dto.AddressDTO.State,
                    dto.AddressDTO.ZipCode
                );
            }

            var user = new UserEntity(
                dto.UserName,
                dto.Password,
                dto.Name,
                dto.PhoneNumber,
                dto.Email,
                dto.Cpf,
                address
            );

            return _userServiceDomain.AddAsync(user);

        }
    }
}
