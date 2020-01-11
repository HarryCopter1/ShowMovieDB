using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    public class Movie : EntityBase<int>
    {
        public string Title { get; private set; }

        public DateTime Release_Time { get; private set; }

        public string Studio { get; private set; }

        public string Language { get; private set; }

        public Language Language_ID { get; private set; }

        public ICollection<Career> People { get; private set; }

        public ICollection<Genre> Genres { get; private set; }

        public ICollection<Awards> Awards { get; private set; }
        
        public int Rental_Duration { get; private set; }

        public float IMDBRating { get; private set; }

        public int Length { get; private set; } 

        public string Rating { get; private set; }
    }
}
