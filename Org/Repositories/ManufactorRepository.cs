using System;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Domain;

namespace Org.Repositories
{
    public class ManufactorRepository : Repository<Manufactor>, IManufactorRepository, IDisposable
    {
        public ManufactorRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public override Manufactor Add(Manufactor manufactor)
        {
            var result = base.Add(manufactor);

            _updateService.Add(result);

            return result;
        }

        public void Update(Manufactor manufactor)
        {
            var target = Items.First(x => x.Id == manufactor.Id);
            _context.Entry(target).CurrentValues.SetValues(manufactor);

            _context.SaveChanges();

            _updateService.Update(manufactor);
        }

        public override void Delete(Manufactor manufactor)
        {
            base.Delete(manufactor);

            _updateService.Delete(manufactor);
        }
    }
}