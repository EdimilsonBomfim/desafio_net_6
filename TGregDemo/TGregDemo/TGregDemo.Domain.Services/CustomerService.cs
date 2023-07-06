using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Core.Services;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Domain.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
