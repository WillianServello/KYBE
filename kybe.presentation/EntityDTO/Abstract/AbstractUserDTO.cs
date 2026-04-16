using kybe.presentation.EntityViewModel.Abstract;
using kybe_domain.Entity.ValueObject;
using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.EntityDTO.Abstract
{
    public abstract class AbstractUserDTO : AbstractEntityDTO
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
        public AddressDTO? AddressDTO { get; set; }
    }
}
