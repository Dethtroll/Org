using System.Collections.Generic;
using Org.Domain;

namespace Org.Common.Services
{
    public interface IEmployeeProductsReportGenerator
    {
        byte[] Generate(Employee employee, IEnumerable<Product> products);
    }
}