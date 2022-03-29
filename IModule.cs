namespace minimal_api
{
    public interface IModule
    {
        IServiceCollection RegisterServices(IServiceCollection services);
        IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpointRouteBuilder);
    }

}
