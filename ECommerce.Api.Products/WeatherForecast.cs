using System;

namespace ECommerce.Api.Products
{
    public class WeatherForecast
    {

        public string Summary { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }
}
