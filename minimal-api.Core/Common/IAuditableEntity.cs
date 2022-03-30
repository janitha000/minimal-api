using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.Common
{
    public interface IAuditableEntity
    {
       DateTime Created { get; set; }
        DateTime Updated { get; set; }
        bool IsDeleted { get; set; }
    }
}
