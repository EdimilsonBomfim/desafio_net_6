using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Web.Data
{
    public class TGregDemoWebContext : DbContext
    {
        public TGregDemoWebContext (DbContextOptions<TGregDemoWebContext> options)
            : base(options)
        {
        }

        public DbSet<TGregDemo.Domain.Entities.Customer> Customers { get; set; } = default!;

        public DbSet<TGregDemo.Domain.Entities.Adress>? Adresses { get; set; }
    }
}
