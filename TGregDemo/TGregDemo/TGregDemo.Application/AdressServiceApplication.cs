using AutoMapper;
using TGregDemo.Application.DTOs;
using TGregDemo.Application.Interfaces;
using TGregDemo.Domain.Core.Services;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Application
{
    public class AdressServiceApplication : IAdressServiceApplication
    {
        private readonly IAdressService _adressService;
        private readonly IMapper _mapper;

        public AdressServiceApplication(IAdressService adressService, IMapper mapper)
        {
            _adressService = adressService;
            _mapper = mapper;
        }

        public void Add(AdressDTO adressDTO)
        {
            var adress = _mapper.Map<Adress>(adressDTO);
            _adressService.Add(adress);
        }

        public IEnumerable<AdressDTO> GetAll()
        {
            var adresses = _adressService.GetAll();
            var adressesDTO = _mapper.Map<IEnumerable<AdressDTO>>(adresses);

            return adressesDTO;
        }

        public IEnumerable<AdressDTO> GetByCustomerId(Guid customerId)
        {
            var adresses = _adressService.GetByCustomerId(customerId);
            var adressesDTO = _mapper.Map<IEnumerable<AdressDTO>>(adresses);
            return adressesDTO;
        }

        public AdressDTO GetById(Guid id)
        {
            var adress = _adressService.GetById(id);
            var adressDTO = _mapper.Map<AdressDTO>(adress);

            return adressDTO;
        }

        public void Remove(AdressDTO adressDTO)
        {
            var adress = _mapper.Map<Adress>(adressDTO);
            _adressService.Remove(adress);
        }

        public void Update(AdressDTO adressDTO)
        {
            var adress = _mapper.Map<Adress>(adressDTO);
            _adressService.Update(adress);
        }
    }
}
