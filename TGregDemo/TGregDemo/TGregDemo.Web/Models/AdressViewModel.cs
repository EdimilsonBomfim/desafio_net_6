using System.ComponentModel.DataAnnotations;

namespace TGregDemo.Web.Models
{
    public class AdressViewModel
    {
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Digite endereço do cliente.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [Display(Name = "Rua/Avenida/Logradouro")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o numero")]
        [Display(Name = "Numero")]
        public string Number { get; set; }

        [Required]        
        [DisplayFormat(DataFormatString = "{0:99999-999}")]
        [Display(Name = "CEP")]
        public string PostalCode { get; set; }

        [Required]        
        public string City { get; set; }
        
        [Display(Name = "UF")]
        [Required(ErrorMessage = "Digite a Unidade federal nome do produto.")]
        public string State { get; set; }
    }
}
