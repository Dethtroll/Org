namespace Org.Pes
{
    public class EmployeeEditPe : EmployeeIndexPe
    {
        protected new string Name { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }
}