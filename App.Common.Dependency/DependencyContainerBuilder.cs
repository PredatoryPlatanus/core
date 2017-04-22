using App.Business.Contracts;
using App.Db.Access;
using App.Db.Contracts;
using Autofac;

namespace App.Common.Dependency
{
    public class DependencyContainerBuilder
    {
        private readonly ContainerBuilder container;
        public ContainerBuilder Container => container;

        public DependencyContainerBuilder()
        {
            container = new ContainerBuilder();

            RegisterRepositories();
            RegisterServices();
        }

        private void RegisterRepositories()
        {
            container.RegisterType<IWeatherForecastRepository>().As<WeatherForecastRepository>();
        }

        private void RegisterServices()
        {
            container.RegisterType<IWeatherForecastService>().As<IWeatherForecastService>();
        }
    }
}
