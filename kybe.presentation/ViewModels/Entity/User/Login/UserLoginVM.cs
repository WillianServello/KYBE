using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.Entity.User.Login
{
    public sealed class UserLoginVM
    {
        [Required(ErrorMessage = "Informe o usuário")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a senha")]
        public string Password { get; set; } = string.Empty;
    }
}
