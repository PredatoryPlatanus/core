using App.Business;
using App.Business.Contracts;
using App.Db.Access;
using App.Db.Contracts;
using Autofac;

namespace App.Common.Dependency
{
    public class DependencyContainerBuilder
    {
        private readonly ContainerBuilder builder;
        public ContainerBuilder Builder => builder;

        public DependencyContainerBuilder()
        {
            builder = new ContainerBuilder();

            RegisterRepositories();
            RegisterServices();
        }

        private void RegisterRepositories()
        {
            builder.RegisterType<WeatherForecastRepository>().As<IWeatherForecastRepository>();
        }

        private void RegisterServices()
        {
            builder.RegisterType<WeatherForecastService>().As<IWeatherForecastService>();
        }
    }
}
