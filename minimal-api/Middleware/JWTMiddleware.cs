using Microsoft.Extensions.Options;
using minimal_api.Application.Common.Interface;
using minimal_api.Application.Common.Model;

namespace minimal_api.Authorization
{
    public class JWTMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IOptions<AppSettings> _appSettings;

        public JWTMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next=next;
            _appSettings=appSettings;
        }

        public async Task Invoke(HttpContext context, IRepository<User> _repository, IJWTUtils jWTUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jWTUtils.ValidateJwtToken(token);

            if(userId != null)
            {
                var user = await _repository.Get(userId);
                context.Items["User"] = user;
            }

            await _next(context);
        }
    }
}
