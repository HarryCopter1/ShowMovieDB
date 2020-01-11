using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Root
{
    public interface IRepository<T, TKey>
        where T : EntityBase<TKey>
        where TKey : struct
    {
        Task<List<T>> ToListAsync();

        Task AddAsync(T entity);

        void Delete(T entity);

        void Update(T entity);

        Task<T> FindByIdAsync(TKey entity);
    }
}
