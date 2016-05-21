using System.Collections.Generic;
using System.IO;
using System.Linq;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Common.Views;
using Org.Pes;

namespace Org.Presenters
{
    public class EmployeeReportPresenter
    {
        private readonly IEmployeeReportView _view;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeProductsReportGenerator _generator;

        public EmployeeReportPresenter(IEmployeeReportView view, IEmployeeRepository employeeRepository, IEmployeeProductsReportGenerator generator)
        {
            _view = view;
            _employeeRepository = employeeRepository;
            _generator = generator;

            _view.Loaded += View_Loaded;
            _view.LoadProducts += View_LoadProducts;
            _view.ExportRequested += View_ExportRequested;
        }

        private void View_Loaded()
        {
            var employees = _employeeRepository.Get()
                .Select(x => new DicIndexPe
                {
                    Id = x.Id,
                    Name = $"{x.FirstName} {x.MiddleName} {x.LastName}"
                })
                .ToList();
            _view.InitEmployees(employees);
        }

        private void View_LoadProducts(int employeeId)
        {
            var employee = _employeeRepository.FirstOrDefault(x => x.Id == employeeId);
            if (employee != null)
            {
                var employees = employee.Products
                    .Select(x => new ProductIntexPe
                    {
                        Id = x.Id,
                        Category = x.Category.Name,
                        Number = x.Number
                    })
                    .ToList();

                _view.InitProducts(employees);
                return;
            }

            _view.InitProducts(new List<ProductIntexPe>());
        }

        private void View_ExportRequested(int employeeId, IEnumerable<int> productIds, string filepath)
        {
            var employee = _employeeRepository.FirstOrDefault(x => x.Id == employeeId);
            if (employee == null) return;

            var products = employee.Products
                .Where(p => productIds.Contains(p.Id))
                .ToList();

            File.WriteAllBytes(filepath, _generator.Generate(employee, products));
        }
    }
}