using Org.Common.Services;
using Org.Domain;
using System;

namespace Org.Services
{
    public class UpdateService : IUpdateService
    {
        protected static readonly UpdateService _serviceInstance;
        public Action<Client> ClientAdded { get; set; }
        public Action<Vendor> VendorAdded { get; set; }
        public Action<Employee> EmployeeAdded { get; set; }
        public Action<Client> ClientUpdated { get; set; }
        public Action<Vendor> VendorUpdated { get; set; }
        public Action<Employee> EmployeeUpdated { get; set; }

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

        static UpdateService()
        {
            _serviceInstance = new UpdateService();
        }

        protected UpdateService()
        {
        }

        public static UpdateService GetService()
        {
            return _serviceInstance;
        }
    }
}
