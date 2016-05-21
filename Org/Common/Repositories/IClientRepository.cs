using Org.Domain;

namespace Org.Common.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        void Update(Client company);
    }
}