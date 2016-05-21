using Org.Domain;

namespace Org.Common.Repositories
{
    public interface IVendorRepository : IRepository<Vendor>
    {
        void Update(Vendor vendor);
    }
}