using Org.Domain;
using System.Data.Entity;

namespace Org.Common.Repositories
{
    public class OrgContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Manufactor> Manufactors { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public OrgContext()
            : base("name=Org.Properties.Settings.DataBaseConnectionString")
        {
        }
    }
}
