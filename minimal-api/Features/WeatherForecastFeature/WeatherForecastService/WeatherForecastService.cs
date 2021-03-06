namespace minimal_api.Features.WeatherForecastFeature.WeatherForecastService
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public List<WeatherForecast> GetForecasts()
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var forecast = Enumerable.Range(1, 5).Select(index =>
                   new WeatherForecast
                   (
                       DateTime.Now.AddDays(index),
                       Random.Shared.Next(-20, 55),
                       summaries[Random.Shared.Next(summaries.Length)]
                   ))
                    .ToArray();
            return forecast.ToList();
        }
    }
}
