using Org.Common.Services;
using Org.Domain;
using System;

namespace Org.Services
{
    public class UpdateService : IUpdateService
    {
        protected static readonly UpdateService ServiceInstance;

        public Action<Client> ClientAdded { get; set; }
        public Action<Vendor> VendorAdded { get; set; }
        public Action<Employee> EmployeeAdded { get; set; }
        public Action<ProductCategory> ProductCategoryAdded { get; set; }
        public Action<Manufactor> ManufactorAdded { get; set; }
        public Action<Client> ClientUpdated { get; set; }
        public Action<Vendor> VendorUpdated { get; set; }
        public Action<Employee> EmployeeUpdated { get; set; }
        public Action<Manufactor> ManufactorUpdated { get; set; }
        public Action<ProductCategory> ProductCategoryUpdated { get; set; }
        public Action<Client> ClientDeleted { get; set; }
        public Action<Vendor> VendorDeleted { get; set; }
        public Action<Employee> EmployeeDeleted { get; set; }
        public Action<Manufactor> ManufactorDeleted { get; set; }
        public Action<ProductCategory> ProductCategoryDeleted { get; set; }
        
        static UpdateService()
        {
            ServiceInstance = new UpdateService();
        }

        protected UpdateService()
        {
        }

        public void Add(Client client)
        {
            ClientAdded?.Invoke(client);
        }
        public void Add(Vendor vendor)
        {
            VendorAdded?.Invoke(vendor);
        }
        public void Add(Employee employee)
        {
            EmployeeAdded?.Invoke(employee);
        }

        public void Update(Client client)
        {
            ClientUpdated?.Invoke(client);
        }
        public void Update(Vendor vendor)
        {
            VendorUpdated?.Invoke(vendor);
        }
        public void Update(Employee employee)
        {
            EmployeeUpdated?.Invoke(employee);
        }
        public void Delete(Client client)
        {
            ClientDeleted?.Invoke(client);
        }
        public void Delete(Vendor vendor)
        {
            VendorDeleted?.Invoke(vendor);
        }
        public void Delete(Employee employee)
        {
            EmployeeDeleted?.Invoke(employee);
        }

        public static UpdateService GetService()
        {
            return ServiceInstance;
        }

        public void Add(Manufactor manufactor)
        {
            ManufactorAdded?.Invoke(manufactor);
        }

        public void Update(Manufactor manufactor)
        {
            ManufactorUpdated?.Invoke(manufactor);
        }

        public void Delete(Manufactor manufactor)
        {
            ManufactorDeleted?.Invoke(manufactor);
        }

        public void Add(ProductCategory manufactor)
        {
            ProductCategoryAdded?.Invoke(manufactor);
        }

        public void Update(ProductCategory manufactor)
        {
            ProductCategoryUpdated?.Invoke(manufactor);
        }

        public void Delete(ProductCategory manufactor)
        {
            ProductCategoryDeleted?.Invoke(manufactor);
        }
    }
}
