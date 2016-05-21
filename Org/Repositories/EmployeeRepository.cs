using System;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Domain;

namespace Org.Repositories
{
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