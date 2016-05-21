using System;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Domain;

namespace Org.Repositories
{
    public class VendorRepository : Repository<Vendor>, IVendorRepository, IDisposable
    {
        public VendorRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public override Vendor Add(Vendor vendor)
        {
            var result = base.Add(vendor);
            
            _updateService.Add(result);

            return result;
        }

        public void Update(Vendor vendor)
        {
            var target = Items.First(x => x.Id == vendor.Id);
            _context.Entry(target).CurrentValues.SetValues(vendor);
            _context.SaveChanges();

            _updateService.Update(vendor);
        }

        public override void Delete(Vendor vendor)
        {
            base.Delete(vendor);

            _updateService.Delete(vendor);
        }
    }
}