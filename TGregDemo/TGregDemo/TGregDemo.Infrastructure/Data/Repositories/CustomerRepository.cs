using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
        }
    }
}
