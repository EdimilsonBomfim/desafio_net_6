using AutoMapper;
using TGregDemo.Application.DTOs;
using TGregDemo.Application.DTOs.Customers;
using TGregDemo.Application.Interfaces;
using TGregDemo.Domain.Core.Services;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Application
{
    public class CustomerServiceApplication : ICustomerServiceApplication
    {
        private readonly ICustomerService _customerService;
        private readonly IAdressService _adressService;
        private readonly IMapper _mapper;

        public CustomerServiceApplication(ICustomerService customerService, IAdressService adressService, IMapper mapper)
        {
            _customerService = customerService;
            _adressService = adressService;
            _mapper = mapper;
        }

        public void Add(CreateCustomerDTO createCustomerDTO)
        {
            var customer = _mapper.Map<Customer>(createCustomerDTO);
            _customerService.Add(customer);
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            var customers = _customerService.GetAll();
            var customersDTO = _mapper.Map<IEnumerable<CustomerDTO>>(customers);

            if (customersDTO != null && customersDTO.Any())
            {
                foreach (var customerDTO in customersDTO)
                {
                    var adresses = _adressService.GetByCustomerId(customerDTO.Id);

                    foreach (var adress in adresses)
                    {
                        customerDTO.Adresses.Add(_mapper.Map<AdressDTO>(adress));
                    }
                }
            }
            
            return customersDTO;
        }

        public CustomerDTO GetById(Guid id)
        {
            var customer = _customerService.GetById(id);
            var customerDTO = _mapper.Map<CustomerDTO>(customer);

            if (customerDTO != null)
            {
                var adresses = _adressService.GetByCustomerId(customerDTO.Id);

                foreach (var adress in adresses)
                {
                    customerDTO.Adresses.Add(_mapper.Map<AdressDTO>(adress));
                }
            }            

            return customerDTO;
        }

        public void Remove(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            _customerService.Remove(customer);
        }

        public void Update(UpdateCustomerDTO updateCustomerDTO)
        {
            var customer = _mapper.Map<Customer>(updateCustomerDTO);
            _customerService.Update(customer);
        }
    }
}
