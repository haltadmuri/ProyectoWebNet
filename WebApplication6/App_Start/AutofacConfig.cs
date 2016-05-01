using Autofac;
using Autofac.Integration.Mvc;
using Dominio;
using Infraestructure;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Controllers;

namespace WebApplication6.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CustomersController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<CustomerService>().As<ICustomerService<Customer>>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepository>().InstancePerHttpRequest();
            builder.RegisterType<Customer>().InstancePerHttpRequest();

            builder.RegisterModelBinderProvider();
            var Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }
    }
}
