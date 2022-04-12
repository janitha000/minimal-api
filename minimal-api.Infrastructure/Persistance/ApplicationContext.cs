using Microsoft.EntityFrameworkCore;
using minimal_api.Application.Common.Interface;
using minimal_api.Authorization;
using minimal_api.Core.Common;
using minimal_api.Features.ToDoFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync()
        {
            foreach (var entity in ChangeTracker.Entries<IAuditableEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.Created = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entity.Entity.Updated = DateTime.UtcNow;
                        break;
                    case EntityState.Deleted:
                        entity.Entity.IsDeleted = true;
                        entity.Entity.Updated = DateTime.UtcNow;
                        break;
                }
            }
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }


    }
}
