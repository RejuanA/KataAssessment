using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheckoutKata.Shared
{
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
