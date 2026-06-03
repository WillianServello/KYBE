namespace kybe_application.DTOs.AccountDTOs
{
    public sealed class AccountAuditLogDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
