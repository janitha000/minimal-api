using minimal_api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.School
{
    public class SchoolUser : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
