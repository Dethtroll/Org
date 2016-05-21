using Org.Domain;

namespace Org.Common.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        void Update(Employee employee);
    }
}