using TGregDemo.Domain.Entities;

namespace TGregDemo.Domain.Core.Repositories
{
    public interface IAdressRepository : IBaseRepository<Adress>
    {
        IEnumerable<Adress> GetByCustomerId(Guid customerId);
    }
}
