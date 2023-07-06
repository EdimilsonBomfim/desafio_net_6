using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Infrastructure.Data.Repositories
{
    public class AdressRepository : BaseRepository<Adress>, IAdressRepository
    {


        public AdressRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
        }

        public IEnumerable<Adress> GetByCustomerId(Guid customerId)
        {
            return _sqlServerContext.Set<Adress>().Where(w => w.CustomerId == customerId).ToList();
        }
    }
}
