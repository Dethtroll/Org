using System;
using System.Collections.Generic;
using Org.Pes;

namespace Org.Common.Views
{
    public interface IEmployeesView
    {
        Action Loaded { get; set; }
        Action AddProduct { get; set; }
        Action<EmployeeEditPe> AddRequested { get; set; }
        Action<EmployeeEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action<int> DeleteRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitEmployees(IEnumerable<EmployeeIndexPe> employees);
        void ShowEmployee(EmployeeEditPe pe);
        void ShowEmptyEmployee();
    }
}