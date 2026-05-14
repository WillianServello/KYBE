using kybe_application.Roles;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.Controllers.Entity
{
    public sealed class UserController : Controller
    {
        //private readonly UserService _userService;

        //public UserController(UserService userService)
        //{
        //    _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        //}

        public IActionResult Index()
        {
                return  View();
        }
    }
}
