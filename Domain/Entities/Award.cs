using Domain.Root;
using System;

namespace Domain.Entities
{
    public class Award : EntityBase<int>
    {
        public string Name { get; private set; }

        public DateTime Date { get; private set; }



    }
}