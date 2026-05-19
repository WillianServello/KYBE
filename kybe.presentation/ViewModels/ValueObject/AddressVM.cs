using System.ComponentModel.DataAnnotations;

namespace kybe.presentation.ViewModels.ValueObject
{
    public class AddressVM
    {
        [Required(ErrorMessage = "Cidade é obrigatorio.")]
        [MaxLength(128, ErrorMessage = "O maximo de carecteres é 128.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Estado é obrigatorio.")]
        [MaxLength(2, ErrorMessage = "O maximo de carecteres é 2.")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rua é obrigatorio.")]
        [MaxLength(128, ErrorMessage = "O maximo de carecteres é 128.")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Número é obrigatorio.")]
        [MaxLength(20, ErrorMessage = "O maximo de carecteres é 20.")]
        public string Number { get; set; } = string.Empty;

        [Required(ErrorMessage = "CEP é obrigatorio.")]
        [MaxLength(10, ErrorMessage = "O maximo de carecteres é 10.")]
        public string ZipCode { get; set; } = string.Empty;

        [MaxLength(128, ErrorMessage = "O maximo de carecteres é 128.")]
        [Required(ErrorMessage = "Bairro é obrigatorio.")]
        public string Neighborhood { get; set; } = string.Empty;

        [MaxLength(128, ErrorMessage = "O maximo de carecteres é 128.")]
        [Required(ErrorMessage = "Complemento é obrigatorio.")]
        public string Complementary { get; set; } = string.Empty;

        protected AddressVM() { }


    }
}
