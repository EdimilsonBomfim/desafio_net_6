using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TGregDemo.Domain.Entities
{
    //[Table("Adresses")]
    public class Adress : Entity
    {
        //[Key]
        public Guid CustomerId { get; set; }
   
        //[Column(TypeName = "varchar(100)")]
        //[Required(ErrorMessage = "Digite endereço do cliente.")]
        //[MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        //[StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        //[Display(Name = "Rua/Avenida/Logradouro")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Informe o numero")]
        //[Column(TypeName = "varchar(15)")]
        //[Display(Name = "Numero")]
        public string Number { get; set; }

        //[Required]
        //[Column(TypeName = "varchar(8)")]
        //[DisplayFormat(DataFormatString = "{0:99999-999}")]
        //[Display(Name = "CEP")]
        public string PostalCode { get; set; }

        //[Required]
        //[Column(TypeName = "varchar(100)")]
        public string City { get; set; }

        //[Column(TypeName = "varchar(2)")]
        //[Display(Name = "UF")]
        //[Required(ErrorMessage = "Digite a Unidade federal nome do produto.")]
        public string State { get; set; }
    }
}
