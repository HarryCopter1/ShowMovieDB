using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    class MovieCast : EntityBase
    {
        public string Film_ID { get; private set; }

        public string Actor_ID { get; private set; }

        public Actor Actor { get; private set; }

        public Movie Movie { get; private set; }
    }
}
