using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;

namespace Domain.Entities
{
    class MovieGenre : EntityBase
    {
        public string Category_ID { get; private set; }

        public string Actor_ID { get; private set; }

        public Genre Genre { get; private set; }

        public Movie Movie { get; private set; }
    }
}
