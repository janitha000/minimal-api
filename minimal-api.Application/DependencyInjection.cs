using Microsoft.Extensions.DependencyInjection;
using minimal_api.Application.TodoApplication;
using minimal_api.Application.ToDoApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IToDoService, ToDoService>();

            return services;
        }
    }
}
