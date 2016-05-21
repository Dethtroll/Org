using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Org.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime FirstWorkDay { get; set; }
        public string Position { get; set; }
        public string Degree { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}