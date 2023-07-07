using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TGregDemo.Application.DTOs;
using TGregDemo.Application.Interfaces;

namespace TGregDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdressController : ControllerBase
    {
        private readonly IAdressServiceApplication _adressServiceApplication;

        public AdressController(IAdressServiceApplication adressServiceApplication)
        {
            _adressServiceApplication = adressServiceApplication;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AdressDTO>> Get()
        {
            var adresssDTO = _adressServiceApplication.GetAll();
            return Ok(adresssDTO);
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            var adress = _adressServiceApplication.GetById(id);
            return Ok(adress);
        }

        [HttpPost]
        public ActionResult Post([FromBody] AdressDTO adressDTO)
        {
            try
            {
                _adressServiceApplication.Add(adressDTO);
                return StatusCode(201, new { message = "Adress created." });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] AdressDTO adressDTO)
        {
            try
            {
                _adressServiceApplication.Update(adressDTO);
                return StatusCode(201, new { message = "Adress updated." });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(AdressDTO adressDTO)
        {
            try
            {
                _adressServiceApplication.Remove(adressDTO);
                return StatusCode(201, new { message = "Adress deleted." });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
