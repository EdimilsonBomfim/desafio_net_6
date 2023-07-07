using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TGregDemo.Domain.Entities
{
    //[Table("Customers")]
    public class Customer : Entity
    {
        //[Column(TypeName = "varchar(100)")]
        //[Required(ErrorMessage = "Digite o nome do cliente.")]
        //[MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        //[StringLength(100, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        //[Display(Name = "Rua/Avenida/Logradouro")]
        public string Name { get; set; }

        //[Column(TypeName = "varchar(150)")]
        //[Required(ErrorMessage = "Digite o email.")]
        //[MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        //[StringLength(200, ErrorMessage = "O tamanho máximo são 150 caracteres.")]
        //[Display(Name = "e-mail")]
        public string Email { get; set; }

        //[Column(TypeName = "varchar(150)")]
        //[MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        //[StringLength(100, ErrorMessage = "O tamanho máximo são 100 caracteres.")]
        //[Display(Name = "e-mail")]
        public string Logo { get; set; }

        //public IEnumerable<Adress> Adresses { get; set; }
    }
}
