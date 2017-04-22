using System;
using App.Common;

namespace App.Db.Entities
{
    public class WeatherForecast : Entity
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
    }
}
