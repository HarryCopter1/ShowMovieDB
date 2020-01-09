using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    class Country : EntityBase
    {
        public string Name { get; private set; }
    }
}
