using TGregDemo.Domain.Entities;

namespace TGregDemo.Domain.Core.Services
{
    public interface IAdressService : IBaseService<Adress>
    {
        IEnumerable<Adress> GetByCustomerId(Guid customerId);
    }
}
