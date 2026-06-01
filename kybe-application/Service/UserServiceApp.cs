using kybe_application.DTOs.CommonDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.ISecurity;
using kybe_application.Interface.IService.IUserService;
using kybe_domain.Interface.IService.IUser;
using kybe_domain.Models.Entity;
using kybe_domain.Models.ValueObject;
using System.Net;

namespace kybe_application.Service
{
    public sealed class UserServiceApp : IUserServiceApp
    {
        private readonly IUserServiceDomain _userServiceDomain;
        private readonly IPasswordHasher _passwordHasher;

        public UserServiceApp(IUserServiceDomain userServiceDomain, IPasswordHasher passwordHasher)
        {
            _userServiceDomain = userServiceDomain;
            _passwordHasher = passwordHasher;   
        }

        public async Task<InformationUserDTO> GetByIdAsync(Guid id)
        {
            var user = await _userServiceDomain.GetByIdAsync(id);

            if (user is null)
                throw new InvalidOperationException("Usuário não encontrado.");

            return new InformationUserDTO
            {
                UserName = user.UserName,
                Name = user.Name,
                LastName = user.LastName!,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Cpf = user.Cpf,

                AddressDTO = user.Address is null ? null : new AddressDTO
                {
                    Street = user.Address.Street,
                    Number = user.Address.Number,
                    Complementary = user.Address.Complementary,
                    Neighborhood = user.Address.Neighborhood,
                    City = user.Address.City,
                    State = user.Address.State,
                    ZipCode = user.Address.ZipCode
                }
            };
        }

        public Task RegisterAsync(RegisterUserDTO dto)
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

        public async Task UpdateAsync(Guid userId, EditUserDTO dto)
        {

           var user = await _userServiceDomain.GetByIdAsync(userId);

            if (user is null)
                throw new Exception("Usuário não encontrado.");

            user.UpdateUser(
                dto.UserName,
                dto.Name,
                dto.LastName,
                dto.PhoneNumber,
                dto.Email,
                dto.Cpf
            );

            await _userServiceDomain.UpdateAsync(user);
        }
    }
}
