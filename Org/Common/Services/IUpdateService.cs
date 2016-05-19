using System;
using Org.Domain;

namespace Org.Common.Services
{
    public interface IUpdateService
    {
        Action<Client> ClientAdded { get; set; }
        Action<Client> ClientUpdated { get; set; }
        Action<Client> ClientDeleted { get; set; }
        Action<Employee> EmployeeAdded { get; set; }
        Action<Employee> EmployeeUpdated { get; set; }
        Action<Employee> EmployeeDeleted { get; set; }
        Action<Vendor> VendorAdded { get; set; }
        Action<Vendor> VendorUpdated { get; set; }
        Action<Vendor> VendorDeleted { get; set; }
        Action<Manufactor> ManufactorAdded { get; set; }
        Action<Manufactor> ManufactorUpdated { get; set; }
        Action<Manufactor> ManufactorDeleted { get; set; }
        Action<ProductCategory> ProductCategoryAdded { get; set; }
        Action<ProductCategory> ProductCategoryUpdated { get; set; }
        Action<ProductCategory> ProductCategoryDeleted { get; set; }

        void Add(Client client);
        void Add(Employee employee);
        void Add(Vendor vendor);
        void Add(Manufactor manufactor);
        void Add(ProductCategory productCategory);
        void Update(Client client);
        void Update(Employee employee);
        void Update(Vendor vendor);
        void Update(Manufactor manufactor);
        void Update(ProductCategory productCategory);
        void Delete(Client client);
        void Delete(Employee employee);
        void Delete(Vendor vendor);
        void Delete(Manufactor manufactor);
        void Delete(ProductCategory productCategory);
    }
}