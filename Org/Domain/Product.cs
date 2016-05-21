using System;
using System.ComponentModel.DataAnnotations;

namespace Org.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }
        public decimal Price { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime SendDate { get; set; }
        public int ReceiveCount { get; set; }
        public int SendCount { get; set; }
        public int ReserveCount { get; set; }
        public decimal TotalReceivePrice { get; set; }
        public decimal TotalSendPrice { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }

        public int ManufactorId { get; set; }
        public virtual Manufactor Manufactor { get; set; }

        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
