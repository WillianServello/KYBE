using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.User.Edit;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account
{
    public class DeleteViewComponent : ViewComponent
    {
        private readonly IUserServiceApp _userService;

        public DeleteViewComponent(IUserServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new UserInformationVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View("~/Views/Pages/Account/Components/Delete/Default.cshtml", viewModel);
        }
    }
}
