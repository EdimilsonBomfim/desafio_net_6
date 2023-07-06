using Microsoft.EntityFrameworkCore;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Infrastructure
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) 
        {
        
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}