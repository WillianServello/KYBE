using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.User.Edit;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account
{
    public class HistoryViewComponent : ViewComponent
    {
        private readonly IUserServiceApp _userService;

        public HistoryViewComponent(IUserServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new UserEditInformationVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View("~/Views/Pages/Account/Components/History/Default.cshtml", viewModel);
        }
    }
}
