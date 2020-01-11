using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    public class Director : EntityBase<int>
    {
        public string First_name { get; private set; }

        public string Last_name { get; private set; }

        public string Description { get; private set; }
    }
}
