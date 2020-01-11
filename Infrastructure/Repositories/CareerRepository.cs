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
    class CareerRepository : Repository<Career, int>, ICareerRepository
    {
        public CareerRepository(DbContext databaseContext)
        : base(databaseContext)
        {

        }



    }
}
