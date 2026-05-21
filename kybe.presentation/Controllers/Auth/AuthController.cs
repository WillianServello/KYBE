using kybe.presentation.ViewModels.Entity.User.Login;
using kybe.presentation.ViewModels.Entity.User.Register;
using kybe_application.DTOs.CommonDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace kybe.presentation.Controllers.Auth
{
    public sealed class AuthController : Controller
    {
        private readonly IUserServiceApp _userService;

        public AuthController(IUserServiceApp userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            try
            {
                var dto = SetLogin(viewModel);
                await _userService.LoginAsync(dto);
                return RedirectToAction("Index", "Home");
            }             
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }

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

                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }
        }

        private static RegisterUser SetRegister(UserRegisterVM viewModel)
        {
            return new RegisterUser
            {
                UserName = viewModel.UserName,
                Password = viewModel.Password,
                Name = viewModel.Name,
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

        private static LoginUser SetLogin(UserLoginVM viewModel)
        {
            return new LoginUser
            {
                UserName = viewModel.UserName,
                Password = viewModel.Password
            };
        }
    }
}
