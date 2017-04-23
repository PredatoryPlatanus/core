using System;
using App.Business;
using App.Business.Contracts;
using App.Db.Access;
using App.Db.Contracts;
using Autofac;

namespace App.Common.Dependency
{
    public class AppModule : Module
    {
        private readonly string connectionString;
        public AppModule(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositories(builder);
            RegisterServices(builder);
            base.Load(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherForecastRepository>().As<IWeatherForecastRepository>();
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherForecastService>().As<IWeatherForecastService>();
        }
    }
}
