namespace Org.Pes
{
    public class ProductEditPe : ProductIntexPe
    {
        public new int Category { get; set; }
        public new int Manufactor { get; set; }
        public new int Vendor { get; set; }
        public new int Client { get; set; }
        public new int Employee { get; set; }

        public string Description { get; set; }
    }
}