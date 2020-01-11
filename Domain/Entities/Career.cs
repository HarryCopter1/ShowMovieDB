using Domain.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Career : EntityBase<int>
    {
        public ICollection<People> People { get; private set; }

        public string Position { get; private set; }



    }
}
