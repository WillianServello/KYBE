using kybe.presentation.ViewModels.Entity.User.Components;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace kybe.presentation.Controllers.Entity
{
    [Authorize]
    public sealed class AccountController : Controller
    {
        private readonly IUserServiceApp _userService;

        public AccountController(IUserServiceApp userService)
        {
            _userService = userService;
        }

        public IActionResult Index(AccountTab tab = AccountTab.Privacy)
        {
            return View(new AccountViewModel
            {
                ActiveTab = tab
            });
        }

    }
}
