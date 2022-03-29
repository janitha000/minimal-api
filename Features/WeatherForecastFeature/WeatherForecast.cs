namespace minimal_api.Features.WeatherForecastFeature
{
    public class WeatherForecast
    {
        public int TemperatureF { get; set; }
        public WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
        {
            TemperatureC =  32 + (int)(TemperatureC / 0.5556);
        }
       

    }
}
