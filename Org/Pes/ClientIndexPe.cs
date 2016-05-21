namespace Org.Pes
{
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
}