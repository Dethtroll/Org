using System;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Domain;

namespace Org.Repositories
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository, IDisposable
    {
        public ProductCategoryRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public override ProductCategory Add(ProductCategory manufactor)
        {
            var result = base.Add(manufactor);

            _updateService.Add(result);

            return result;
        }

        public void Update(ProductCategory manufactor)
        {
            var target = Items.First(x => x.Id == manufactor.Id);
            _context.Entry(target).CurrentValues.SetValues(manufactor);

            _context.SaveChanges();

            _updateService.Update(manufactor);
        }

        public override void Delete(ProductCategory manufactor)
        {
            base.Delete(manufactor);

            _updateService.Delete(manufactor);
        }
    }
}