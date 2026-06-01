using kybe.presentation.ViewModels.Common.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kybe.presentation.ViewModels.Entity.User.Register
{
    public class UserRegisterVM : AbstractUserVM
    {
        [Required(ErrorMessage = "O campo 'Usuário' é obrigatorio")]
        [MinLength(3, ErrorMessage = "O campo 'Usuário' precisa ter no minímo 3 caracteres")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo 'Senha' é obrigatorio")]
        [MinLength(8, ErrorMessage = "O campo 'Senha' precisa ter no minímo 8 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo 'Confirmação de Senha' é obrigatorio")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "A Confirmação da Senha deve ser igual a Senha")]
        [NotMapped]
        public string PasswordConfirm { get; set; } = string.Empty;
    }
}
