using kybe.presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using kybe_application.Interface.Service.User;
using kybe.presentation.ViewModels.Entity.Account.Details;

namespace kybe.presentation.ViewComponents.Account
{
    public sealed class MyDataViewComponent : ViewComponent
    {
        private readonly IAccountServiceApp _userService;

        public MyDataViewComponent(IAccountServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new UserDetailsVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View("~/Views/Pages/Account/Components/MyData/Default.cshtml", viewModel);
        }
    }
}