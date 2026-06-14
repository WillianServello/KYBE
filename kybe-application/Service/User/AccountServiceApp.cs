using kybe_application.DTOs.AccountDTOs;
using kybe_application.DTOs.CommonDTOs;
using kybe_application.Interface.Security;
using kybe_application.Interface.Service.User;
using kybe_domain.Interface.Service.User;
using kybe_domain.Models.Common.ValueObject;
using kybe_domain.Models.Entity;

namespace kybe_application.Service.User
{
    public sealed class AccountServiceApp : IAccountServiceApp
    {
        private readonly IAccountServiceDomain _userServiceDomain;
        private readonly IPasswordHasher _passwordHasher;

        public AccountServiceApp(IAccountServiceDomain userServiceDomain, IPasswordHasher passwordHasher)
        {
            _userServiceDomain = userServiceDomain;
            _passwordHasher = passwordHasher;
        }

        public async Task DeleteAsync(Guid userId)
        {
            var user = await _userServiceDomain.GetByIdAsync(userId);

            if (user is null)
                throw new Exception("Usuário não encontrado.");

            await _userServiceDomain.DeleteAsync(user);
        }

        public async Task<List<AccountAuditLogDTO>> GetAllUserNamesAsync()
        {
            var users = await _userServiceDomain.GetAllAsync();

            return users
                .Select(user => new AccountAuditLogDTO
                {
                    Id = user.Id,
                    UserName = user.UserName
                })
                .ToList();
        }

        public async Task<AccountDetailsDTO> GetByIdAsync(Guid id)
        {
            var user = await _userServiceDomain.GetByIdAsync(id);

            if (user is null)
                throw new InvalidOperationException("Usuário não encontrado.");

            return new AccountDetailsDTO
            {
                UserName = user.UserName,
                Name = user.Name,
                LastName = user.LastName!,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Cpf = user.Cpf,
                ProfileDTO = user.Profile,

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

        public Task AddAsync(AccountCreateDTO dto)
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

        public async Task UpdateAsync(Guid userId, AccountUpdateDTO dto)
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
                dto.Cpf,
                dto.Profile
            );

            await _userServiceDomain.UpdateAsync(user);
        }

        public Task<ICollection<AccountDetailsDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
