using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using minimal_api.Application.Common.Interface;
using minimal_api.Application.ToDoApplication;
using minimal_api.Infrastructure.Persistance;
using minimal_api.Infrastructure.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configurations )
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configurations.GetConnectionString("default"), 
                assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Singleton);
            services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
            
            
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<ITodoRepository, ToDoRepository>();

            return services;
        }
    }
}
