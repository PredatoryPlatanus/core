using System;
using App.Db.Models;

namespace App.Db.Contracts
{
    public interface IWeatherForecastRepository : IRepositoryBase<WeatherForecast>
    {
    }
}
