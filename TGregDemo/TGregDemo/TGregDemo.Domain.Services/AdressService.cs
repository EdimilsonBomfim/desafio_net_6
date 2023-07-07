using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Core.Services;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Domain.Services
{
    public class AdressService : BaseService<Adress>, IAdressService
    {
        private readonly IAdressRepository _adressRepository;

        public AdressService(IAdressRepository adressRepository)
            : base(adressRepository)
        {
            _adressRepository = adressRepository;
        }

        public IEnumerable<Adress> GetByCustomerId(Guid customerId)
        {
            return _adressRepository.GetByCustomerId(customerId);
        }
    }
}
