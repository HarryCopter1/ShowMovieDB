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
    class PeopleRepository : Repository<People, int>, IPeopleRepository
    {
        public PeopleRepository(DbContext databaseContext)
        : base(databaseContext)
        {

        }



    }
}
