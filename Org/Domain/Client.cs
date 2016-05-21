﻿using System.ComponentModel.DataAnnotations;

namespace Org.Domain
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}