using minimal_api.Application.ToDoApplication;
using minimal_api.Features.ToDoFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Infrastructure.Persistance.Repository
{
    public class ToDoRepository : EfCoreRepository<ToDo>, ITodoRepository
    {
        public ToDoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
