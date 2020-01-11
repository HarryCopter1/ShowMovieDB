using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Root
{
    public abstract class EntityBase<TKey>
        where TKey : struct
    {
        public virtual TKey Id { get; protected set; }

        public virtual int CreatedBy { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual bool IsTransient
        {
            get
            {
                return Id.Equals(default(TKey));
            }
        }

    }
}
