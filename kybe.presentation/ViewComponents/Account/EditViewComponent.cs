using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.User.Edit;
using kybe_application.Interface.IService.IUserService;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account
{
    public class EditViewComponent : ViewComponent
    {
        private readonly IUserServiceApp _userService;

        public EditViewComponent(IUserServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new UserEditVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Cpf = user.Cpf
            };

            return View("~/Views/Pages/Account/Components/Edit/Default.cshtml", viewModel);
        }
    }
}
