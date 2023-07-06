using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGregDemo.Application.DTOs.Adress;

namespace TGregDemo.Application.DTOs.Customers
{
    public class CreateCustomerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public IList<CreateAdressDTO> Adresses { get; set; }
    }
}
