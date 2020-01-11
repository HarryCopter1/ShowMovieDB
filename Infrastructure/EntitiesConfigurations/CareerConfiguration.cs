using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiesConfigurations
{
    class CareerConfiguration : BaseEntityConfiguration<Career, int>
    {
        public override void Configure(EntityTypeBuilder<Career> builder)
        {
            base.Configure(builder);
        }
    }
}
