using System;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Domain;

namespace Org.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository, IDisposable
    {
        public ClientRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public override Client Add(Client client)
        {
            var result = base.Add(client);

            _updateService.Add(result);

            return result;
        }

        public void Update(Client client)
        {
            var target = Items.First(x => x.Id == client.Id);
            _context.Entry(target).CurrentValues.SetValues(client);
            _context.SaveChanges();

            _updateService.Update(client);
        }

        public override void Delete(Client client)
        {
            base.Delete(client);

            _updateService.Delete(client);
        }
    }
}