using Autofac;
using TGregDemo.Application;
using TGregDemo.Application.Interfaces;
using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Core.Services;
using TGregDemo.Domain.Services;
using TGregDemo.Infrastructure.Data.Repositories;

namespace TGregDemo.Infrastructure.IoC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerServiceApplication>().As<ICustomerServiceApplication>();
            builder.RegisterType<AdressServiceApplication>().As<IAdressServiceApplication>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<AdressService>().As<IAdressService>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<AdressRepository>().As<IAdressRepository>();       
        }
    }
}
