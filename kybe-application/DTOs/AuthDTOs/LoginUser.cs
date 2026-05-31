namespace kybe_application.DTOs.AuthDTOs
{
    public sealed class LoginUser
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
