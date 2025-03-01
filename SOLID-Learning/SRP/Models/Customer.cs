﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SRP.Models
{
    [Table("Customers")]
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
    }
}
