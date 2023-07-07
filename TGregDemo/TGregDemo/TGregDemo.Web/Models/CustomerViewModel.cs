using System.ComponentModel.DataAnnotations;

namespace TGregDemo.Web.Models
{
    public class CustomerViewModel
    {
        [Required(ErrorMessage = "Digite o nome do cliente.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [Display(Name = "Rua/Avenida/Logradouro")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o email.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 150 caracteres.")]
        [Display(Name = "e-mail")]
        public string Email { get; set; }

        [MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo são 100 caracteres.")]
        [Display(Name = "e-mail")]
        public string Logo { get; set; }

        public IEnumerable<AdressViewModel> Adresses { get; set; }
    }
}
