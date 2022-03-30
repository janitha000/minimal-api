using minimal_api.Features.ToDoFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application.TodoApplication
{
    public interface IToDoService
    {
        IEnumerable<ToDo> GetAllTodos();
    }
}
