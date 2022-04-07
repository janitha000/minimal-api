using Microsoft.AspNetCore.Mvc;
using minimal_api.Application.Common.Interface;
using minimal_api.Core.School;

namespace minimal_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IRepository<Department> _repository;

        public DepartmentController(IRepository<Department> repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _repository.GetAll();
        }


    }
}
