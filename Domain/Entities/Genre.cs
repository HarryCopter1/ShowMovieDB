using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    public class Genre : EntityBase<int>
    {
        public string Name { get; private set; }
    }
}
