using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    class Director : EntityBase
    {
        public string First_name { get; private set; }
        public string Last_name { get; private set; }
        public string Description { get; private set; }
    }
}
