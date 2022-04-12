using minimal_api.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Application.Common.Interface
{
    public interface IJWTUtils
    {
        public string GenerateJwtToke(User user);
        public string? ValidateJwtToken(string token);

    }
}
