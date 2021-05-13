using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

namespace Product.DependencyInjection
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