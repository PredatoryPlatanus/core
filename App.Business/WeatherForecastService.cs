using System;
using System.Collections.Generic;
using System.Linq;
using App.Business.Contracts;
using App.Business.Entities;
using App.Db.Contracts;

namespace App.Business
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository weatherForecastRepository;
        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            this.weatherForecastRepository = weatherForecastRepository;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            //mapping
            return weatherForecastRepository.Get().Select(q => new WeatherForecast
            {
                Id = q.Id,
                Date = q.Date,
                TemperatureC = q.TemperatureC
            }).ToList();
        }
    }
}
