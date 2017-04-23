using System;
using System.Collections.Generic;
using System.Linq;
using App.Db.Contracts;
using Moq;
using Machine.Specifications;
using It = Machine.Specifications.It;

namespace App.Business.Tests
{
    public class WeatherForecastServiceSpecs
    {
        [Subject(typeof(WeatherForecastService))]
        public class WeatherForecastServiceContext
        {
            protected static Mock<IWeatherForecastRepository> weatherForecastRepository;

            protected static WeatherForecastService weatherForecastService;

            private static WeatherForecastService service;

            private Establish context = () =>
            {
                weatherForecastRepository = new Mock<IWeatherForecastRepository>();
                weatherForecastService = new WeatherForecastService(weatherForecastRepository.Object);
            };
        }
        [Subject(typeof(WeatherForecastService))]
        public class When_get_all_invoked : WeatherForecastServiceContext
        {
            static IQueryable<Db.Entities.WeatherForecast> weatherForecasts_on_get_all =
                new List<Db.Entities.WeatherForecast>
                {
                    new Db.Entities.WeatherForecast {Date = DateTime.Now, Id = 1, TemperatureC = 40}
                }.AsQueryable();

            static IEnumerable<Business.Entities.WeatherForecast> result;

            private Establish context = () =>
            {
                weatherForecastRepository.Setup(q => q.Get()).Returns(weatherForecasts_on_get_all);
            };

            Because of = () => result = weatherForecastService.GetAll();

            It should_not_be_null = () =>
            {
                result.ShouldNotBeNull();
            };

            It should_have_correct_count = () =>
            {
                result.Count().ShouldEqual(weatherForecasts_on_get_all.Count());
            };
        }
    }
}
