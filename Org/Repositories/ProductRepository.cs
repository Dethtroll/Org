using System;
using System.Collections.Generic;
using Org.Common.Repositories;
using Org.Domain;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using Org.Common.Services;

namespace Org.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OrgContext _context;
        protected readonly IUpdateService _updateService;

        protected readonly IDbSet<T> Items;

        public Repository(OrgContext context, IUpdateService updateService)
        {
            _context = context;
            _updateService = updateService;
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

        public virtual T Add(T product)
        {
            var result = Items.Add(product);
            var r =_context.SaveChanges();

            return result;
        }

        public virtual void Delete(T product)
        {
            Items.Remove(product);
            _context.SaveChanges();
        }
    }

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

    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository, IDisposable
    {
        public ProductCategoryRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }
    }

    public class ManufactorRepository : Repository<Manufactor>, IManufactorRepository, IDisposable
    {
        public ManufactorRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }
    }

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

    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository, IDisposable
    {
        public EmployeeRepository(OrgContext context, IUpdateService updateService)
            : base(context, updateService)
        {
        }

        public override Employee Add(Employee employee)
        {
            var result = base.Add(employee);

            _updateService.Add(result);

            return result;
        }

        public void Update(Employee employee)
        {
            var target = Items.First(x => x.Id == employee.Id);
            _context.Entry(target).CurrentValues.SetValues(employee);
            _context.SaveChanges();

            _updateService.Update(employee);
        }

        public override void Delete(Employee employee)
        {
            base.Delete(employee);

            _updateService.Delete(employee);
        }
    }
}
