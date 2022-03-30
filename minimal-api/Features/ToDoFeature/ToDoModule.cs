namespace minimal_api.Features.ToDoFeature
{
    public class ToDoModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapGet("/todos", () => ToDoEndpoints.GetTodos).WithName("GetToDos");

            return endpointRouteBuilder;
        }

        public IServiceCollection RegisterServices(IServiceCollection services)
        {
            return services;
        }
    }
}
