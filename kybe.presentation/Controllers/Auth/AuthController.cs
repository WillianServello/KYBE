using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.Controllers.Auth
{
    public sealed class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
