using Org.Domain;
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

    public class ProductEditPe : ProductIntexPe
    {
        public new int Category { get; set; }
        public new int Manufactor { get; set; }
        public new int Vendor { get; set; }
        public new int Client { get; set; }
        public new int Employee { get; set; }

        public string Description { get; set; }
    }

    public class ProductCategoryIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is ProductCategoryIndexPe && Id == ((ProductCategoryIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class ManufactorIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is ManufactorIndexPe && Id == ((ManufactorIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class VendorIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is VendorIndexPe && Id == ((VendorIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class ClientIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is ClientIndexPe && Id == ((ClientIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class EmployeeIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is EmployeeIndexPe && Id == ((EmployeeIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
