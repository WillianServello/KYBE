using kybe.presentation.ViewModels.Entity.User.Components;
using kybe.presentation.ViewModels.Entity.User.Edit;
using kybe.presentation.ViewModels.Entity.User.Register;
using kybe_application.DTOs.CommonDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace kybe.presentation.Controllers.Entity
{
    
    public sealed class AccountController : Controller
    {
        private readonly IUserServiceApp _userService;

        public AccountController(IUserServiceApp userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index(AccountTab tab = AccountTab.MyData)
        {
            return View(new AccountViewModel
            {
                ActiveTab = tab
            });
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            try
            {
                var dto = SetRegister(viewModel);
                await _userService.RegisterAsync(dto);

                return RedirectToAction("Login", "Auth");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(UserEditVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", new AccountViewModel
                {
                    ActiveTab = AccountTab.Edit
                });
            }

            try
            {
                var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (userIdClaim is null)
                    return RedirectToAction("Login", "Auth");

                var userId = Guid.Parse(userIdClaim);

                var dto = SetUpdate(viewModel);

                await _userService.UpdateAsync(userId, dto);

                return RedirectToAction("Index", "Account", new { tab = AccountTab.MyData });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return View("Index", new AccountViewModel
                {
                    ActiveTab = AccountTab.Edit
                });
            }
        }
        private static RegisterUserDTO SetRegister(UserRegisterVM viewModel)
        {
            return new RegisterUserDTO
            {
                UserName = viewModel.UserName,
                Password = viewModel.Password,
                Name = viewModel.Name,
                LastName = viewModel.LastName!,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email,
                Cpf = viewModel.Cpf,
                AddressDTO = viewModel.AddressVM is null
                ? null
                : new AddressDTO
                {
                    Street = viewModel.AddressVM.Street,
                    Number = viewModel.AddressVM.Number,
                    Complementary = viewModel.AddressVM.Complementary,
                    Neighborhood = viewModel.AddressVM.Neighborhood,
                    City = viewModel.AddressVM.City,
                    State = viewModel.AddressVM.State,
                    ZipCode = viewModel.AddressVM.ZipCode
                }
            };
        }

        private static EditUserDTO SetUpdate(UserEditVM viewModel)
        {
            return new EditUserDTO
            {
                UserName = viewModel.UserName,
                Name = viewModel.Name,
                LastName = viewModel.LastName!,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email,
                Cpf = viewModel.Cpf,
            };
        }


    }
}
