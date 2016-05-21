using System;
using Org.Common.Repositories;
using Org.Domain;
using System.Linq;
using Org.Common.Services;

namespace Org.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository, IDisposable
    {
        public ProductRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public void Update(Product product)
        {
            var target = Items.First(x => x.Id == product.Id);
            _context.Entry(target).CurrentValues.SetValues(product);
            
            _context.SaveChanges();
        }
    }
}
