using System;
using System.Collections.Generic;
using Org.Pes;

namespace Org.Common.Views
{
    public interface IEmployeeReportView
    {
        Action Loaded { get; set; }
        Action<int> LoadProducts { get; set; }
        Action<int, IEnumerable<int>, string> ExportRequested { get; set; }

        void InitEmployees(IEnumerable<DicIndexPe> employees);
        void InitProducts(IEnumerable<ProductIntexPe> products);
    }
}