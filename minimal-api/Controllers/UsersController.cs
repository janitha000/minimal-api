using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using minimal_api.Application.Common.Interface;
using minimal_api.Application.Common.Model;
using minimal_api.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace minimal_api.Controllers
{
    [Authorization.Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _repo;
        private readonly IJWTUtils _jwtUtils;

        public UsersController(IRepository<User> repo, IJWTUtils jwtUtils)
        {
            _repo=repo;
            _jwtUtils=jwtUtils;
        }

        [Authorization.AllowAnonymous]
        [HttpPost]public async IActionResult Authenticate(AuthenticateRequest model)
        {
            var user =await  _repo.Get(x => x.UserName == model.UserName);
            if(user == null) throw new AppException("Username or password is incorrect");

            var JWTToken = _jwtUtils.GenerateJwtToke(user);
            return Ok(new AuthenticateResponse(user, JWTToken));
        }

        [Authorization.Authorize(Role.Admin)]
        [HttpGet]
        public IActionResult Get()
        {
            var users = _repo.GetAll();
            return Ok(users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
