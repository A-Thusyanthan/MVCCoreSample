using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public DateTime DateRegistered { get; set; }

        public Boolean Day1 { get; set; }

        public Boolean Day2 { get; set; }

        public Boolean Day3 { get; set; }

        public string AdditionalRequest { get; set; }
    }

}
