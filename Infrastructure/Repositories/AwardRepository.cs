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
    public class AwardRepository : Repository<Award, int>, IAwardRepository
    {
        public AwardRepository(DbContext databaseContext)
        : base (databaseContext)
        {

        }



    }
}
