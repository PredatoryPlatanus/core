using System.Collections.Generic;
using System.Linq;
using App.Business.Contracts;
using App.Db.Contracts;
using Microsoft.AspNetCore.Mvc;
using App.Web.Models;

namespace App.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IWeatherForecastService weatherForecastService;
        public SampleDataController(IWeatherForecastService weatherForecastService)
        {
            this.weatherForecastService = weatherForecastService;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            return weatherForecastService.GetAll().Select(q => new WeatherForecast
            {
                DateFormatted = q.Date.ToString(),
                TemperatureC = q.TemperatureC,
                Summary = "herp"
            });
        }
    }
}
