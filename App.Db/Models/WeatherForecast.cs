using System;
using System.Collections.Generic;
using System.Text;
using App.Common;

namespace App.Db.Models
{
    public class WeatherForecast : Entity
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
    }
}
