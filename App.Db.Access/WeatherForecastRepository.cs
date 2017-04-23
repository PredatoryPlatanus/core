using System;
using System.Collections.Generic;
using System.Text;
using App.Db.Contracts;
using App.Db.Entities;

namespace App.Db.Access
{
    public class WeatherForecastRepository : RepositoryBase<WeatherForecast>, IWeatherForecastRepository
    {
        public WeatherForecastRepository(AppDbContext context) : base(context)
        {
        }
    }
}
