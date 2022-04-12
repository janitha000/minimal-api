using minimal_api.Core.Interfaces;
using System.Text.Json.Serialization;

namespace minimal_api.Authorization
{
    public class User : BaseEntity<Guid>
    {
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        [JsonIgnore] //To prevent send back in the api response
        public string PasswordHash { get; set; }
    }
}
