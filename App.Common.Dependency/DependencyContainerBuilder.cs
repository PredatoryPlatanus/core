using System;
using App.Business;
using App.Db;
using App.Db.Access;
using Autofac;
using Microsoft.EntityFrameworkCore;

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
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionString);
            builder.RegisterInstance(optionsBuilder.Options);

            builder.RegisterType<DbContextOptions>();
            builder.RegisterType<AppDbContext>()
                .AsSelf()
                .InstancePerLifetimeScope()
                .WithParameter("options", optionsBuilder.Options);

            RegisterRepositories(builder);
            RegisterServices(builder);
            base.Load(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherForecastRepository>().AsImplementedInterfaces();
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherForecastService>().AsImplementedInterfaces();
        }
    }
}
