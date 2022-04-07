using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using minimal_api.Core.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Infrastructure.Persistance.Configuration
{
    public class SchoolUserConfiguration : IEntityTypeConfiguration<SchoolUser>
    {
        public void Configure(EntityTypeBuilder<SchoolUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
        }
    }
}
