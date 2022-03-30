using minimal_api.Application.Common.Interface;
using minimal_api.Features.ToDoFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application.ToDoApplication
{
    public interface ITodoRepository : IRepository<ToDo>
    {
    }
}
