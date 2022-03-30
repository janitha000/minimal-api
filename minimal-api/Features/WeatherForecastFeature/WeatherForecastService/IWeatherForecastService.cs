namespace minimal_api.Features.WeatherForecastFeature.WeatherForecastService
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> GetForecasts();
    }
}
