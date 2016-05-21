using System;

namespace Org.Pes
{
    public class EmployeeIndexPe
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime FirstWorkDay { get; set; }
        public string Position { get; set; }
        public string Degree { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is EmployeeIndexPe && Id == ((EmployeeIndexPe)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}