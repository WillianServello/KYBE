using kybe.presentation.ViewModels.Entity.Auth.Login;
using kybe.presentation.ViewModels.Entity.User.Register;
using kybe_application.DTOs.AuthDTOs;
using kybe_application.DTOs.CommonDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.Controllers.Auth
{
    public sealed class AuthController : Controller
    {
        private readonly IUserServiceApp _userService;
        private readonly IAuthServiceApp _authService;

        public AuthController(IUserServiceApp userService, IAuthServiceApp authService)
        {
            _userService = userService;
            _authService = authService;
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

                var token = await _authService.LoginAsync(dto);

                if (token is null)
                {
                    TempData["Error"] = "Usuário ou senha inválidos";
                    return RedirectToAction("Login");
                }

                Response.Cookies.Append(
                    "JWT",
                    token,
                    new CookieOptions
                    {
                        HttpOnly = true,
                        Secure = true,
                        SameSite = SameSiteMode.Strict,
                        Expires = DateTime.UtcNow.AddHours(1)
                    }
                );

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
