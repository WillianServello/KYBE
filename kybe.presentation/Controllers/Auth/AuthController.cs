using kybe.presentation.ViewModels.Entity.Auth.Login;
using kybe.presentation.ViewModels.Entity.User.Register;
using kybe_application.DTOs.AuthDTOs;
using kybe_application.DTOs.CommonDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPost]
        [Authorize]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("JWT");

            return RedirectToAction("Login", "Auth");
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
