using Autofac;
using Autofac.Integration.Mvc;
using DaylyHelper.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DaylyHelper.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<DaylyHelperData>()
                   .As<IDayHelperData>()
                   .InstancePerRequest();
            builder.RegisterType<DayHelperDbContext>().InstancePerRequest();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}