using Domain.Entities;
using Domain.Root.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AwardsRepository : Repository<Awards, int>, IAwardsRepository
    {
        public AwardsRepository(DbContext databaseContext)
        : base (databaseContext)
        {

        }



    }
}
