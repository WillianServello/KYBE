using kybe.presentation.ViewModels.Common.Abstract;
using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.Entity.Account.Person.User.Details
{
    public sealed class AccountDetailsVM : AbstractUserVM
    {
        [Required(ErrorMessage = "O campo 'Usuário' é obrigatorio")]
        [MinLength(3, ErrorMessage = "O campo 'Usuário' precisa ter no minímo 3 caracteres")]
        public string UserName { get; set; } = string.Empty;

    }
}
