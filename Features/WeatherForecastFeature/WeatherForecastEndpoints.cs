using minimal_api.Features.WeatherForecastFeature.WeatherForecastService;

namespace minimal_api.Features.WeatherForecastFeature
{
    public static class WeatherForecastEndpoints
    {
        public static IResult GetWeathrForecasts(IWeatherForecastService _service)
        {
            return  Results.Ok(_service.GetForecasts());
        }
    }
        
    
}
