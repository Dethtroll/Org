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

        void Add(Client client);
        void Add(Employee employee);
        void Add(Vendor vendor);
        void Update(Client client);
        void Update(Employee employee);
        void Update(Vendor vendor);
        void Delete(Client client);
        void Delete(Employee employee);
        void Delete(Vendor vendor);
    }
}