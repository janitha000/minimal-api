using minimal_api.Features.WeatherForecastFeature;
using minimal_api.Features.WeatherForecastFeature.WeatherForecastService;

namespace minimal_api.Features.WeatherForecastModule
{
    public class WeatherForecastModule : IModule
    {

    
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapGet("/weatherforecast", WeatherForecastEndpoints.GetWeathrForecasts).WithName("GetWeatherForecasts");

            return endpointRouteBuilder;
        }

        public IServiceCollection RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            return services;
        }


    }


}


