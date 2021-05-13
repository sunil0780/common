using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Web.Http;

namespace RaulandAustralia.DependencyInjectionCore
{
    public static class DependencyInjector
    {
        public static ContainerBuilder InitializeBuilder(HttpConfiguration configuration, Assembly applicationAssembly)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(applicationAssembly).PropertiesAutowired();
            builder.RegisterWebApiFilterProvider(configuration);

            return builder;
        }

        public static IContainer GetContainer(ContainerBuilder builder)
        {
            return builder.Build();
        }
    }
}
