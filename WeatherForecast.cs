using System;


/* Test comment again, the apa is gone now */

/* Test of row 2 and more */

namespace KattenJanssonTestar1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

