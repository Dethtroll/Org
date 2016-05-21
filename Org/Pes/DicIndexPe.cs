namespace Org.Pes
{
    public class DicIndexPe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
        
        public override bool Equals(object obj)
        {
            return obj is DicIndexPe && Id == ((DicIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}