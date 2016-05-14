using System;
using Org.Domain;

namespace Org.Common.Services
{
    public interface IUpdateService
    {
        Action<Client> ClientAdded { get; set; }
        Action<Client> ClientUpdated { get; set; }
        Action<Employee> EmployeeAdded { get; set; }
        Action<Employee> EmployeeUpdated { get; set; }
        Action<Vendor> VendorAdded { get; set; }
        Action<Vendor> VendorUpdated { get; set; }

        void Add(Client client);
        void Add(Employee employee);
        void Add(Vendor vendor);
        void Update(Vendor vendor);
        void Update(Client client);
        void Update(Employee employee);
    }
}