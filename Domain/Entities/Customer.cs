using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Root;


namespace Domain.Entities
{
    internal class Customer : EntityBase
    {
        public string First_Name { get; private set; }

        public string Last_Name { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public bool Active { get; private set; }

        public DateTime Create_Date { get; private set; }
    }
}
