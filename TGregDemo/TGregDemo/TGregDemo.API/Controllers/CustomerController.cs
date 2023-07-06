using Microsoft.AspNetCore.Mvc;
using TGregDemo.Application.DTOs;
using TGregDemo.Application.DTOs.Customers;
using TGregDemo.Application.Interfaces;

namespace TGregDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServiceApplication _customerServiceApplication;

        public CustomerController(ICustomerServiceApplication customerServiceApplication)
        {
            _customerServiceApplication = customerServiceApplication;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDTO>> Get()
        {
            var customersDTO = _customerServiceApplication.GetAll();
            return Ok(customersDTO);
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            var customer = _customerServiceApplication.GetById(id);
            return Ok(customer);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateCustomerDTO createCustomerDTO)
        {
            try
            {
                _customerServiceApplication.Add(createCustomerDTO);
                return StatusCode(201, new { message = "Customer created." });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UpdateCustomerDTO updateCustomerDTO)
        {
            try
            {
                _customerServiceApplication.Update(updateCustomerDTO);
                return StatusCode(201, new { message = "Customer updated." });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete(CustomerDTO customerDTO)
        {
            try
            {
                _customerServiceApplication.Remove(customerDTO);
                return StatusCode(201, new { message = "Customer deleted." });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
