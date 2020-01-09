using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    class City : EntityBase
    {
        public string Name { get; private set; }

        public int Country_ID { get; private set; }

        public Country Country { get; private set; }
    }
}
