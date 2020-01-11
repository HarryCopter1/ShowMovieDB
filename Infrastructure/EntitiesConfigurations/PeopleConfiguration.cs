using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfigurations
{
    class PeopleConfiguration : BaseEntityConfiguration<People, int>
    {
        public override void Configure(EntityTypeBuilder<People> builder)
        {
            base.Configure(builder);
        }
    }
}
