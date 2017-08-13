using Autofac;
using Autofac.Integration.Mvc;
using HorseRace.Configurations;
using HorseRace.ServiceProxy.HttpHandler;
using HorseRace.ServiceProxy.Race;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace HorseRace
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());
            RegisterServices(builder);

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<RaceService>().As<IRaceService>().InstancePerDependency();
            builder.RegisterType<ConfigurationManager>().As<IConfigurationManager>().InstancePerDependency();
            builder.RegisterType<HttpClientHandler>().As<IHttpHandler>().SingleInstance();
        }
    }
}
