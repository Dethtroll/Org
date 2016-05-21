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
}
