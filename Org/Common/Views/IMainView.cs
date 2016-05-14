using System;
using System.Collections.Generic;
using Org.Pes;

namespace Org.Common.Views
{
    public interface IMainView
    {
        Action Loaded { get; set; }
        Action AddProduct { get; set; }
        Action<ProductEditPe> AddRequested { get; set; }
        Action<ProductEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitProducts(IEnumerable<ProductIntexPe> products, IEnumerable<ProductCategoryIndexPe> categories, IEnumerable<ManufactorIndexPe> manufactors, IEnumerable<VendorIndexPe> vendors, IEnumerable<ClientIndexPe> clients, IEnumerable<EmployeeIndexPe> employess);
        void ShowProduct(ProductEditPe pe);
        void ShowEmptyProduct();

        void ShowEmployeesWindow();
    }

    public interface IEmployeesView
    {
        Action Loaded { get; set; }
        Action AddProduct { get; set; }
        Action<EmployeeEditPe> AddRequested { get; set; }
        Action<EmployeeEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitEmployees(IEnumerable<EmployeeIndexPe> employees);
        void ShowEmployee(EmployeeEditPe pe);
        void ShowEmptyEmployee();
    }
    
    public interface ICompaniesView
    {
        Action Loaded { get; set; }
        Action AddCompany { get; set; }
        Action<CompanyEditPe> AddRequested { get; set; }
        Action<CompanyEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitCompanies(IEnumerable<CompanyIndexPe> companies);
        void ShowCompany(CompanyEditPe pe);
        void ShowEmptyCompany();
    }
}
