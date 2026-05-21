using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.ISecurity;
using kybe_application.Interface.IService.IUserService;
using kybe_domain.Interface.IService.IUser;
using kybe_domain.Models.Entity;
using kybe_domain.Models.ValueObject;

namespace kybe_application.Service
{
    public sealed class UserAppService : IUserServiceApp
    {
        private readonly IUserServiceDomain _userServiceDomain;
        private readonly IPasswordHasher _passwordHasher;

        public UserAppService(IUserServiceDomain userServiceDomain, IPasswordHasher passwordHasher)
        {
            _userServiceDomain = userServiceDomain;
            _passwordHasher = passwordHasher;   
        }

        public async Task LoginAsync(LoginUser dto)
        {
            
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
            var passwordHash = _passwordHasher.Hash(dto.Password);

            var user = new UserEntity(
                dto.UserName,
                passwordHash,
                dto.Name,
                dto.LastName,
                dto.PhoneNumber,
                dto.Email,
                dto.Cpf,
                address!
            );

            return _userServiceDomain.AddAsync(user);
        }

    }
}
