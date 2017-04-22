using System.Collections.Generic;
using System.Linq;
using App.Db.Contracts;
using Microsoft.AspNetCore.Mvc;
using App.Web.Models;

namespace App.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IWeatherForecastRepository weatherForecastRepository;
        public SampleDataController(IWeatherForecastRepository weatherForecastRepository)
        {
            this.weatherForecastRepository = weatherForecastRepository;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            return weatherForecastRepository.Get().Select(q => new WeatherForecast
            {
                DateFormatted = q.Date.ToString(),
                TemperatureC = q.TemperatureC,
                Summary = "herp"
            });
        }
    }
}
