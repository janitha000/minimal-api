using minimal_api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.Common
{
    public abstract class AuditableWithBaseEntity<T> : BaseEntity<T>, IAuditableEntity
    {
        public DateTime Created { get ; set ; }
        public DateTime Updated { get ; set ; }
        public bool IsDeleted { get; set; } = false;
    }
}
