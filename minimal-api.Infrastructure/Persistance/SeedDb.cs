using minimal_api.Authorization;

namespace minimal_api.Infrastructure.Persistance
{
    public static  class SeedDb
    {
        public static void SeedDbOnStartUp(ApplicationDbContext context)
        {
            var testUsers = new List<User>
            {
                new User { Id = new Guid(), FirstName = "Admin", LastName = "User", UserName = "admin",  Role = Role.Admin },
                new User { Id = new Guid(), FirstName = "Normal", LastName = "User", UserName = "user", Role = Role.User }
            };

            context.Users.AddRange(testUsers);
            context.SaveChanges();
            
        }
    }
}
