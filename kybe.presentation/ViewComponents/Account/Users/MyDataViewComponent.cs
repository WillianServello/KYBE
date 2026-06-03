using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.Account.Person.User.Details;
using kybe_application.Interface.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account.Users
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

            var viewModel = new AccountDetailsVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View("~/Views/Pages/Account/Components/Users/MyData/Default.cshtml", viewModel);
        }
    }
}