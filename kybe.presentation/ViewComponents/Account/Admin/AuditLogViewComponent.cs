using kybe.presentation.ViewModels.Entity.Account.Person.Admin.AuditLog;
using kybe_application.Interface.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.ViewComponents.Account.Admin
{
    public sealed class AuditLogViewComponent : ViewComponent
    {
        private readonly IAccountServiceApp _accountService;

        public AuditLogViewComponent(IAccountServiceApp accountService)
        {
            _accountService = accountService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var usersDto = await _accountService.GetAllUserNamesAsync();

            var usersVm = usersDto
                .Select(user => new AccountAuditLogVM
                {
                    Id = user.Id,
                    UserName = user.UserName
                })
                .ToList();

            return View("~/Views/Pages/Account/Components/Admin/AuditLog/Default.cshtml", usersVm);
        }
    }
}
