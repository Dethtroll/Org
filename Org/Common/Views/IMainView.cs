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

        void InitProducts(IEnumerable<ProductIntexPe> products, IEnumerable<ProductCategoryIndexPe> categories, IEnumerable<ManufactorIndexPe> manufactors, IEnumerable<VendorIndexPe> vendors, IEnumerable<ClientIndexPe> clients, IEnumerable<EmployeeIndexPe> employess);
        void ShowProduct(ProductEditPe pe);
    }
}
