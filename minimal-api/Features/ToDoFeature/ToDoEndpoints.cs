using minimal_api.Application.TodoApplication;

namespace minimal_api.Features.ToDoFeature
{
    public static class ToDoEndpoints
    {
        public static IResult GetTodos(IToDoService _service)
        {
            return Results.Ok(_service.GetAllTodos());
        }
    }
}
