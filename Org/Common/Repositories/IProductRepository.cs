using Org.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Org.Common.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        T Add(T product);
    }

    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }

    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
    }

    public interface IManufactorRepository : IRepository<Manufactor>
    {
    }

    public interface IVendorRepository : IRepository<Vendor>
    {
        void Update(Vendor vendor);
    }

    public interface IClientRepository : IRepository<Client>
    {
        void Update(Client company);
    }

    public interface IEmployeeRepository : IRepository<Employee>
    {
        void Update(Employee employee);
    }
}
