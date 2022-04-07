using minimal_api.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.School
{
    public class Department : AuditableWithBaseEntity<Guid>
    {
        public string DepartmentName { get; set; }
        public ICollection<SchoolUser> Users { get; set; }

    }
}
