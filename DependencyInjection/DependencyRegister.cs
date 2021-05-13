using Autofac;

namespace Product.DependencyInjection
{
    public class DependencyRegister
    {
        public static void Register<Concrete, Abstraction>(ContainerBuilder builder)
            where Concrete : class
            where Abstraction : class
        {
            builder.RegisterType<Concrete>()
                    .As<Abstraction>()
                    .PropertiesAutowired()
                    .InstancePerLifetimeScope();
        }
    }
}