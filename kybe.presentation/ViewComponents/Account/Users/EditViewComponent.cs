using kybe.presentation.Extensions;
using kybe.presentation.ViewModels.Entity.Account.Person.User.Edit;
using kybe_application.Interface.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account.Users
{
    public sealed class EditViewComponent : ViewComponent
    {
        private readonly IAccountServiceApp _userService;

        public EditViewComponent(IAccountServiceApp userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = UserClaimsPrincipal.GetUserId();

            var user = await _userService.GetByIdAsync(userId);

            var viewModel = new AccountEditVM
            {
                Name = user.Name,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Cpf = user.Cpf
            };

            return View("~/Views/Pages/Account/Components/Users/Edit/Default.cshtml", viewModel);
        }
    }
}
