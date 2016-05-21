using Org.Domain;

namespace Org.Common.Repositories
{
    public interface IManufactorRepository : IRepository<Manufactor>
    {
        void Update(Manufactor vendor);
    }
}