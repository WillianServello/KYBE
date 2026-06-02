using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.Account.Delete;
using kybe_application.Interface.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account
{
    public sealed class DeleteViewComponent : ViewComponent
    {
        private readonly IAccountServiceApp _userService;

        public DeleteViewComponent(IAccountServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new UserDeleteVM
            {
                UserName = user.UserName,
            };

            return View("~/Views/Pages/Account/Components/Delete/Default.cshtml", viewModel);
        }
    }
}
