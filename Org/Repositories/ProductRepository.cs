using System;
using System.Collections.Generic;
using Org.Common.Repositories;
using Org.Domain;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Org.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OrgContext _context;

        protected readonly IDbSet<T> Items;

        public Repository(OrgContext context)
        {
            _context = context;
            Items = _context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            var result = Items;

            if (predicate != null)
            {
                result.Where(predicate);
            }

            return result.ToList();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Items
                .FirstOrDefault(predicate);
        }

        public T Add(T product)
        {
            var result = Items.Add(product);
            var r =_context.SaveChanges();

            return result;
        }
    }

    public class ProductRepository : Repository<Product>, IProductRepository, IDisposable
    {
        public ProductRepository(OrgContext context)
            : base(context)
        {
        }

        public void Update(Product product)
        {
            var target = Items.First(x => x.Id == product.Id);
            _context.Entry(target).CurrentValues.SetValues(product);

            //_context.Products.Attach(product);
            //_context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository, IDisposable
    {
        public ProductCategoryRepository(OrgContext context)
            : base(context)
        {
        }
    }

    public class ManufactorRepository : Repository<Manufactor>, IManufactorRepository, IDisposable
    {
        public ManufactorRepository(OrgContext context)
            : base(context)
        {
        }
    }

    public class VendorRepository : Repository<Vendor>, IVendorRepository, IDisposable
    {
        public VendorRepository(OrgContext context)
            : base(context)
        {
        }
        
        public void Update(Vendor vendor)
        {
            var target = Items.First(x => x.Id == vendor.Id);
            _context.Entry(target).CurrentValues.SetValues(vendor);
            _context.SaveChanges();
        }
    }

    public class ClientRepository : Repository<Client>, IClientRepository, IDisposable
    {
        public ClientRepository(OrgContext context)
            : base(context)
        {
        }
    }

    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository, IDisposable
    {
        public EmployeeRepository(OrgContext context)
            : base(context)
        {
        }
        
        public void Update(Employee employee)
        {
            var target = Items.First(x => x.Id == employee.Id);
            _context.Entry(target).CurrentValues.SetValues(employee);
            _context.SaveChanges();
        }
    }
}
