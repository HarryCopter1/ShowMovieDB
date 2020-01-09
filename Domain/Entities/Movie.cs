using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    class Movie : EntityBase
    {
        public string Title { get; private set; }

        public DateTime Release_Time { get; private set; }

        public string Language { get; private set; }

        public Language Language_ID { get; private set; }

        public Director Director_ID { get; private set; }

        public int Rental_Duration { get; private set; }

        public int Length { get; private set; }

        public float Replacement_Cost { get; private set; }

        public string Rating { get; private set; }
    }
}
