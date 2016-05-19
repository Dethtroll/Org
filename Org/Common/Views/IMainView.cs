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

        void InitProducts(IEnumerable<ProductIntexPe> products, IEnumerable<DicIndexPe> categories, IEnumerable<DicIndexPe> manufactors, IEnumerable<VendorIndexPe> vendors, IEnumerable<ClientIndexPe> clients, IEnumerable<EmployeeIndexPe> employess);
        void ShowProduct(ProductEditPe pe);
        void ShowEmptyProduct();

        void InitCategories(IEnumerable<DicIndexPe> categories);
        void InitManufactors(IEnumerable<DicIndexPe> manufactors);
        void InitVendors(IEnumerable<VendorIndexPe> vendors);
        void InitClients(IEnumerable<ClientIndexPe> clients);
        void InitEmployees(IEnumerable<EmployeeIndexPe> employess);

        void ShowEmployeesWindow();
        void ShowVendorsWindow();
        void ShowClientsWindow();
    }

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

    public interface ICompaniesView
    {
        Action Loaded { get; set; }
        Action AddCompany { get; set; }
        Action<CompanyEditPe> AddRequested { get; set; }
        Action<CompanyEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action<int> DeleteRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitCompanies(IEnumerable<CompanyIndexPe> companies);
        void ShowCompany(CompanyEditPe pe);
        void ShowEmptyCompany();
    }

    public interface IDictionayView
    {
        Action Loaded { get; set; }
        Action AddItem { get; set; }
        Action<DicEditPe> AddRequested { get; set; }
        Action<DicEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action<int> DeleteRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitDic(IEnumerable<DicIndexPe> companies);
        void ShowItem(DicEditPe pe);
        void ShowEmptyItem();
    }
}
