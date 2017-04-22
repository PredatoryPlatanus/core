using System;
using App.Common;

namespace App.Business.Entities
{
    public class WeatherForecast : Entity
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
    }
}
