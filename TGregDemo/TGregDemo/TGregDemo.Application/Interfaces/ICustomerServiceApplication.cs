using TGregDemo.Application.DTOs;
using TGregDemo.Application.DTOs.Customers;

namespace TGregDemo.Application.Interfaces
{
    public interface ICustomerServiceApplication
    {
        void Add(CreateCustomerDTO customerDTO);

        void Update(UpdateCustomerDTO customerDTO);

        void Remove(CustomerDTO customerDTO);

        IEnumerable<CustomerDTO> GetAll();

        CustomerDTO GetById(Guid id);
    }
}
