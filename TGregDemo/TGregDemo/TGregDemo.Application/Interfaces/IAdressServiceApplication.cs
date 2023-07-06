using TGregDemo.Application.DTOs;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Application.Interfaces
{
    public interface IAdressServiceApplication
    {
        void Add(AdressDTO adressDTO);

        void Update(AdressDTO adressDTO);

        void Remove(AdressDTO adressDTO);

        IEnumerable<AdressDTO> GetAll();

        AdressDTO GetById(Guid id);

        IEnumerable<AdressDTO> GetByCustomerId(Guid customerId);
    }
}
