using kybe.presentation.ViewModels.Common.Abstract;

namespace kybe.presentation.ViewModels.Entity.Account.Person.Admin.AuditLog
{
    public sealed class AccountAuditLogVM : AbstractEntityVM
    {
        public string UserName { get; set; } = string.Empty;
    }
}
