using System;
using System.Collections.Generic;
using App.Business.Entities;

namespace App.Business.Contracts
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
