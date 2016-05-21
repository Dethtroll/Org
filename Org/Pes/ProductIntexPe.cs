using System;

namespace Org.Pes
{
    public class ProductIntexPe
    {
        public int Id { get; set; }

        public string Category { get; set; }
        public string Manufactor { get; set; }
        public decimal Price { get; set; }
        public string Number { get; set; }
        public string Vendor { get; set; }
        public string Client { get; set; }
        public string Employee { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime SendDate { get; set; }
        public int ReceiveCount { get; set; }
        public int SendCount { get; set; }
        public int ReserveCount { get; set; }
        public decimal TotalReceivePrice { get; set; }
        public decimal TotalSendPrice { get; set; }
    }
}
