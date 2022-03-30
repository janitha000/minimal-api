using minimal_api.Application.TodoApplication;
using minimal_api.Features.ToDoFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application.ToDoApplication
{
    public class ToDoService : IToDoService
    {
        private readonly ITodoRepository _repository;

        public ToDoService(ITodoRepository repository)
        {
            _repository=repository;
        }

        public IEnumerable<ToDo> GetAllTodos()
        {
            //var ToDos = new List<ToDo>
            //{
            //    new ToDo("Janitha")
            //};

            //return ToDos;

            return _repository.GetAll();
        }
    }
}
