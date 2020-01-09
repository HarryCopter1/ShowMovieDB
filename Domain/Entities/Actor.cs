using Domain.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    class Actor : EntityBase
    {
        public string First_Name { get; private set; }
        public string Last_Name { get; private set; }
    }
}
