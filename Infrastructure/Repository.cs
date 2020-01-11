using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Root;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : EntityBase<TKey>
        where TKey : struct
    {   
        public Repository(DbContext dbContext)
        {
            DatabaseContext = dbContext;
        }

        public DbContext DatabaseContext { get; }

        public virtual Task AddAsync(TEntity entity)
        {
            return DatabaseContext.Set<TEntity>().AddAsync(entity);
        }

        public virtual Task<List<TEntity>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindByIdAsync(TKey entity)
        {
            throw new NotImplementedException();
        }


        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
