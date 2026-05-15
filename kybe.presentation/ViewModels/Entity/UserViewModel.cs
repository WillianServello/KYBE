using kybe.presentation.ViewModels.Abstract;
using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.Entity
{
    public class UserViewModel : GenerictUserViewModel
    {
        [Required(ErrorMessage = "O campo 'Usuário' é obrigatorio" )]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo 'Senha' é obrigatorio")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo 'Confirmação de Senha' é obrigatorio")]
        [Compare(nameof(Password), ErrorMessage = "A Confirmação da Senha deve ser igual a Senha")]
        public string PasswordConfirm { get; set; } = string.Empty;
    }
}
