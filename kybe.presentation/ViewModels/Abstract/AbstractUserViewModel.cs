using kybe.presentation.ViewModels.ValueObject;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.Abstract
{
    public abstract class AbstractUserViewModel : AbstractEntityViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatorio.")]
        [MaxLength(128, ErrorMessage = "O maximo de carecteres é 128.")]
        [MinLength(3, ErrorMessage = "O minímo de carecteres é 3.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefone é obrigatorio.")]
        [MaxLength(20, ErrorMessage = "O maximo de carecteres é 20.")]
        public string PhoneNumber { get;  set; } = string.Empty;

        [Required(ErrorMessage = "Email é obrigatorio.")]
        [MaxLength(256, ErrorMessage = "O maximo de carecteres é 256.")]
        [EmailAddress(ErrorMessage = "Formato Inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "CPF é obrigatorio.")]
        public string Cpf {get; set;} = string.Empty;

        public AddressVM? AddressVM { get; set; }
    }
}
